#!/usr/bin/env Rscript

# Extract build log substrings by matching a given regex

suppressPackageStartupMessages({
  library(optigrab)
  library(stringi)
  library(stringr)
})

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"
sample_path <<-
  paste(main_path, "/tool/samples", sep = "")

## load other modules
source(paste(main_path, "/r-extractions/utilities.R", sep = ""))

run_analysis <- function(file, regex) {
  log <- read_build_log_from_file(file, sample_path)
  match <- str_extract(log, regex(regex, dotall = TRUE))
  lines <- unlist(stri_split_lines(match, omit_empty = TRUE))
  return(join_extracted_lines(lines))
}

run_regex_search_extraction <- function() {
  regex <- commandArgs()[match("--regex", commandArgs()) + 1]
  result <- run_analysis(file = opt_get("file"), regex = regex)
  cat(result)
}

run_regex_search_extraction()
