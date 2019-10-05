#!/usr/bin/env Rscript

# Extract information from build logs by searching for keywords

suppressPackageStartupMessages({
  library(optigrab)
  library(stringi)
})

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"
sample_path <<-
  paste(main_path, "/tool/samples", sep = "")

## load other modules
source(paste(main_path, "/r-extractions/utilities.R", sep = ""))
source(paste(main_path, "/r-extractions/example-set.R", sep = ""))
source(paste(main_path, "/evaluation/evaluate-results.R", sep = ""))

run_analysis <- function(file, keywords, context_width) {
  log <- read_build_log_from_file(file, sample_path)
  lines <- unlist(stri_split_lines(log, omit_empty = TRUE))

  filtered_lines <- logical(length(lines))
  for (i in 1:length(keywords)) {
    filtered_lines <- filtered_lines | str_detect(lines, fixed(keywords[i]))
  }
  context_added_lines <- filtered_lines
  if (context_width > 0) {
    for (i in 1:length(filtered_lines)) {
      if (filtered_lines[i]) {
        for (j in 1:context_width) {
          context_added_lines[i-j] = TRUE
          context_added_lines[i+j] = TRUE
        }
      }
    }
  }
  return(join_extracted_lines(lines[context_added_lines]))
}

run_keyword_search_step <- function(train_examples, test_examples, step_results) {
  start_time_learning <- Sys.time()
  keywords_chain <- strsplit(step_results[1, "AllKeywords"], ", ")[[1]]
  selected <- select_keywords_to_search(keywords_chain)
  step_results[1, "SearchKeywords"] <- paste(selected, collapse = ", ")
  step_results[1, "LearnedProgram"] <- paste(selected, collapse = ", ")

  end_time_learning <- Sys.time()
  step_results[1, "LearningDuration"] <- sys_timing_to_time(start_time_learning, end_time_learning)
  step_results[1, "TestInputPath"] <- test_examples[1, "input_path"]

  start_time_application <- Sys.time()

  output <- run_analysis(test_examples[1, "input_path"], selected, context_width = 10)

  end_time_application <- Sys.time()
  step_results[1, "ApplicationDuration"] = sys_timing_to_time(start_time_application, end_time_application)

  step_results[1, "TestOutput"] <- output
  step_results
}

run_keyword_search_extraction <- function() {
  verb <- opt_get_verb()

  if (verb == "analyze") {
    keywords_count <- length(commandArgs()) - match("--keywords", commandArgs())[1]
    keywords <- opt_get("keywords", n = keywords_count)
    result <- run_analysis(file = opt_get("file"), keywords = keywords, context_width = 0)
    cat(result)
  } else if (verb == "evaluate") {
    program <- opt_get("program")
    run_evaluation(program = program,
                     selection = opt_get("selection"),
                     include_inputs = opt_get("include-inputs", n = 0),
                     test_count = as.integer(opt_get("test-count")),
                     learning_step_count = as.integer(opt_get("learning-step-count")),
                     verbose = opt_get("verbose", n = 0),
                     step_method = run_keyword_search_step,
                     technique = "keyword")
  }
}

run_keyword_search_extraction()
