suppressPackageStartupMessages({
  library(stringr)
  library(stringi)
  library(wordcloud)
  library(NLP)
  library(XML)
})

## split the given text into
## lines
## and save to separate files in output_path, identified by the file_name_base
split_text <- function(text, file_name_base,  output_path) {
  split <- stri_split_lines(text, omit_empty = TRUE)
  setwd(output_path)
  filename <-
    gsub(".", "", gsub("/", "", file_name_base, fixed = TRUE), fixed = TRUE)
  for (i in seq_along(split[[1]])) {
    writeLines(split[[1]][[i]], paste(filename, i, ".txt", sep = ""))
  }
}

## obtain all lines that output spans in the given file
## to include lines around the actual extraction use `context_lines_count`
get_lines_containing_output <-
  function(file_name,
           base_path,
           output,
           only_output_lines = TRUE,
           context_lines_count = 0,
           visually_separate_context = FALSE,
           split_into_lines = TRUE) {
    lines <- read_build_log_from_file(file_name, base_path)
    output_lines <- lines
    
    if (only_output_lines) {
      lines_with_output_regex <-
        paste0("\n[^\n]*",
              escapeStringAsNotRegex(output),
              "[^\n]*\n")
      output_postion <-
        str_locate(lines, regex(lines_with_output_regex))
      output_lines <-
        substr(lines, output_postion[[1]], output_postion[[2]])

      if (context_lines_count > 0) {
        lines_with_context_regex <-
          paste0("(\n[^\n]*){0,", context_lines_count, "}",
                lines_with_output_regex,
                "([^\n]*\n){0,", context_lines_count, "}")
        context_postion <-
          str_locate(lines, regex(lines_with_context_regex))
        
        pre_context <- substr(lines, context_postion[[1]], output_postion[[1]])
        post_context <- substr(lines, output_postion[[2]], context_postion[[2]])

        output_lines <-
          paste(pre_context, output_lines, post_context, sep = "-=-=-=-=-=-\n\n-=-=-=-=-=-")
      }
    }
    
    if (split_into_lines) {
      output_lines <- stri_split_lines(output_lines, omit_empty = TRUE)
    }
    return(output_lines)
  }

## gets all the lines for a sample with ids.
## returns all lines of the logfile if only_output_lines = FALSE
get_ided_line_samples <-
  function(examples, only_output_lines = TRUE) {
    train_lines <-
      data.frame(id = character(),
                 lines = character(),
                 stringsAsFactors = FALSE)
    
    for (example_row in 1:nrow(examples)) {
      i_p <- examples[example_row, "input_path"]
      o <- examples[example_row, "output"]
      output_lines <-
        get_lines_containing_output(i_p, sample_path, o, only_output_lines = only_output_lines)
      
      lines_frame <-
        data.frame(lines = output_lines, stringsAsFactors = FALSE)
      colnames(lines_frame)[1] <- "lines"
      ids <-
        paste(collapse_input_path(i_p), rownames(lines_frame), sep = ":")
      lines_frame <-
        cbind(id = ids, lines_frame, stringsAsFactors = FALSE)
      
      train_lines <- rbind(train_lines, lines_frame)
    }
    
    return(train_lines)
  }

## shorten input path of sample for a readable identifier
collapse_input_path <- function(path) {
  return(gsub("^(.)[^@]*@(.)[^/]*/([^\\.]*)\\.log", "\\1@\\2/\\3", path))
}

## split the content of the given files using split_text
split_files <- function(files, output_path) {
  dir.create(output_path, showWarnings = FALSE)
  setwd(sample_path)
  for (file in files) {
    file_content <- readChar(file, file.info(file)$size)
    split_text(file_content, file, output_path)
    break
  }
}

## split the output of the given examples using split_text
split_labeled_examples <- function(examples,  output_path) {
  dir.create(output_path, showWarnings = FALSE)
  for (row in 1:nrow(examples)) {
    split_text(examples[row, "output"], examples[row, "input_path"], output_path)
  }
}


## escape all things in a string that would be regex special things
escapeStringAsNotRegex <- function(x = character()) {
  return(paste0("\\Q", x, "\\E"))
  #return(gsub("([.|()\\^{}+$*?]|\\[|\\])", "\\\\\\1", x))
}

## convert nanosecond timestamps / C# ticks to R time
nanosecsToTime <- function(ticks = numeric) {
  sec <- ticks / 1e7
  return(as.POSIXct(sec, origin = "1970-01-01", tz = "UTC"))
}

## convert second time interval to R time
sys_timing_to_time <- function(start, end) {
  return(as.POSIXct(as.numeric(end - start), origin = "1970-01-01", tz = "UTC"))
}

## get buildlog and normalize all the newline types + remove special characters
read_build_log_from_file <- function(file_name, base_path) {
  setwd(base_path)
  file_content <- readChar(file_name, file.info(file_name)$size)
  file_content <- escape_special_characters_buildlog(file_content)

  return(file_content)
}

escape_special_characters_buildlog <- function(text) {
  return(#gsub("[^\U0009\U000a\U000d\U0020-\UD7FF\UE000-\UFFFD]+", "", 
        gsub(rawToChar(as.raw(0x1b)), "",
        gsub("\r", "\n",
        gsub("\r\n", "\n",
        gsub("\n\r", "\n", text)
        ))))#)
}

## creates an empty data frame for evaluation results
empty_results_data_frame <- function() {
  return(
    data.frame(
      ExampleCount = numeric(),
      LearnedProgram = character(),
      TestOutput = character(),
      DesiredTestOutput = character(),
      Accuracy = numeric(),
      Successful = logical(),
      LearningDuration = as.POSIXct(character()),
      ApplicationDuration = as.POSIXct(character()),
      SearchKeywords = character(),
      Categories = character(),
      stringsAsFactors = FALSE
    )
  )
}

## concatenates the extracted lines from line-based exractions
join_extracted_lines <- function(lines) {
  x <- paste(lines, sep = "", collapse = "\n")
  return(x)
}

## build the string identifying an evaluation run
evaluation_identification <-
  function(technique,
           program,
           selection,
           test_count,
           learning_step_count) {
  return(paste(program, technique, selection, test_count, learning_step_count, sep = "-"))
}

## run an evaluation, does example selection, iteration over examples
run_evaluation <-
  function(program,
           selection,
           include_inputs,
           test_count,
           learning_step_count,
           verbose,
           step_method,
           technique) {
    ## load example set
    examples <- get_exampleset(program)
    
    if (selection == "manual") {
      # do nothing with parsed examples
    } else if (selection == "random") {
      examples <- examples[sample(nrow(examples)),]
    } else if (selection == "chronological") {
      examples <-
        examples[order(as.integer(gsub(".*/(.*).log", "\\1", examples[, "input_path"]))), ]
    } else {
      print("selection has to be either 'manual', 'random' or 'chronological'")
    }
    
    if (verbose) {
      print(examples)
    }
    
    results <- empty_results_data_frame()
    
    for (training_step in 1:learning_step_count) {
      ## select on which examples to train / test
      train_examples <- examples[c(1:training_step), ]
      test_examples <-
        examples[c(training_step:training_step + test_count), ]
      
      step_results <-
        step_method(train_examples, test_examples)
      
      step_results[1, "ExampleCount"] <- training_step
      step_results[1, "DesiredTestOutput"] <-
        test_examples[1, "output"]
      
      results <- rbind(results, step_results)
    }
    
    results <- save_evaluation_result(results, program, technique, selection, learning_step_count, test_count)
  }
