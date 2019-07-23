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

run_analysis <- function(file, keywords) {
  log <- read_build_log_from_file(file, sample_path)
  lines <- unlist(stri_split_lines(log, omit_empty = TRUE))

  filtered_lines <- logical(length(lines))
  for (i in 1:length(keywords)) {
    filtered_lines <- filtered_lines | str_detect(lines, fixed(keywords[i]))
  }
  return(join_extracted_lines(lines[filtered_lines]))
}

run_keyword_search_extraction <- function() {
  keywords_count <- length(commandArgs()) - match("--keywords", commandArgs())[1]
  keywords <- opt_get("keywords", n = keywords_count)
  result <- run_analysis(file = opt_get("file"), keywords = keywords)
  cat(result)
}

run_keyword_search_extraction()
