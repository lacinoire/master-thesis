#!/usr/bin/env Rscript

# Extract information from build logs by searching for keywords

suppressPackageStartupMessages({
  library(optigrab)
  library(stringi)
  library(plyr)
})

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"
sample_path <<-
  paste(main_path, "/tool/samples", sep = "")

## load other modules
source(paste(main_path, "/r-extractions/utilities.R", sep = ""))
source(paste(main_path, "/r-extractions/example-set.R", sep = ""))

run_analysis <- function(file, keywords) {
  log <- read_build_log_from_file(file, sample_path)
  lines <- unlist(stri_split_lines(log, omit_empty = TRUE))

  filtered_lines <- logical(length(lines))
  for (i in 1:length(keywords)) {
    filtered_lines <- filtered_lines | str_detect(lines, fixed(keywords[i]))
  }
  # TODO context
  return(join_extracted_lines(lines[filtered_lines]))
}

run_keyword_search_step <- function(train_examples, test_examples, step_results) {
  # TODO somehow consolidate keywords
  # search for them in text and extract stuff around it
  print(step_results[1, "AllKeywords"])
  keywords_chain = strsplit(step_results[1, "AllKeywords"], ", ", fixed=TRUE)
  print(keywords_chain)
  kwdf = data.frame(words = keywords_chain)
  print(kwdf)
  print(count(kwdf))
  print(step_results)
  step_results
}

run_keyword_search_extraction <- function() {
  verb <- opt_get_verb()

  if (verb == "analyze") {
    keywords_count <- length(commandArgs()) - match("--keywords", commandArgs())[1]
    keywords <- opt_get("keywords", n = keywords_count)
    result <- run_analysis(file = opt_get("file"), keywords = keywords)
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
