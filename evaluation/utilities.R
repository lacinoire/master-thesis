library(stringr)
library(stringi)
library(wordcloud)
library(NLP)
library(XML)

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
get_lines_containing_output <-
  function(file_name,
           base_path,
           output,
           only_output_lines = TRUE) {
    lines <- read_build_log_from_file(file_name, base_path)
    
    if (only_output_lines) {
      lines_with_output_regex <-
        paste("\n[^\n]*",
              escapeStringAsNotRegex(output),
              "[^\n]*\n",
              sep = "")
      output_postion <-
        str_locate(lines, regex(lines_with_output_regex))
      
      lines <-
        substr(lines, output_postion[[1]], output_postion[[2]])
    }
    
    split <- stri_split_lines(lines, omit_empty = TRUE)
    return(split)
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

## create a matrix for the documents at the location output_path
create_term_document_matrix <- function(output_path) {
  corpus <- VCorpus(DirSource(output_path, encoding = "UTF-8"))
  # corpus <- tm_map(corpus, stripWhitespace) # remove white spaces
  # corpus <- tm_map(corpus, removeNumbers)   # remove numbers
  # corpus <- tm_map(corpus, removePunctuation) # remove punctuation
  # corpus <- tm_map(corpus, content_transformer(tolower)) # transform everything to lower case
  # # Apply stopword lists
  # corpus <- tm_map(corpus, removeWords, stopwords("en"))
  # corpus <- tm_map(corpus, removeWords, stopwords(language = "en", source = "smart"))
  # corpus <- tm_map(corpus, removeWords, stopwords(language = "en", source = "snowball"))
  # corpus <- tm_map(corpus, removeWords, stopwords(language = "en", source = "stopwords-iso"))
  # corpus <- tm_map(corpus, removeWords, c("abstract", "assert","boolean","break","byte", "case","catch","char","continue","default","do","double","else","enum","extends","final","finally","float","for","if","implements","import","instanceof","int","interface","long","native","new","package","private","protected","public","return","short","static","strictfp","super","syncronized","this","throw","throws","transient","try","void","volatile","while","goto","const","java", "class", "import","github", "http", "html", "for", "while", "then", "private", "public", "protected", "try", "catch","instead","https","http","href","ibm","throw","throws","clone","javadoc","bug", "string","method","list","array","object"))
  # # Applying stemming
  # corpus <- tm_map(corpus, stemDocument, language = "english")
  
  # print(corpus)
  # wordcloud(
  #   corpus,
  #   min.freq = 5,
  #   random.order = FALSE,
  #   colors = brewer.pal(8, "Dark2")
  # )
  # 7. Build the document-by-term matrix
  tdm <-
    DocumentTermMatrix(corpus,
                       control = list(
                         tokenize = Regexp_Tokenizer("\\s+"),
                         wordLengths = c(1, Inf),
                         bounds = list(global = c(2, Inf))
                       ))
  # https://stackoverflow.com/a/13961302/6456126
  rowTotals <-
    apply(tdm , 1, sum) #Find the sum of words in each Document
  tdm.new   <-
    tdm[rowTotals > 0,]           #remove all docs without words
  return(tdm)
}

## escape all things in a string that would be regex special things
escapeStringAsNotRegex <- function(x = character()) {
  return(gsub("([.|()\\^{}+$*?]|\\[|\\])", "\\\\\\1", x))
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
  file_content <-
    gsub(rawToChar(as.raw(0x1b)), "",
         gsub("\r", "\n",
              gsub(
                "\r\n", "\n",
                gsub("\n\r", "\n", file_content)
              )))
  return(file_content)
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
      stringsAsFactors = FALSE
    )
  )
}
