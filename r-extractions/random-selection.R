#!/usr/bin/env Rscript

# Just returning back random lines from the build log
suppressPackageStartupMessages({
  library(optigrab)
  library(stringi)
  library(purrr)
})

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"
sample_path <<-
  paste(main_path, "/tool/samples", sep = "")

## load other modules
source(paste(main_path, "/r-extractions/utilities.R", sep = ""))
source(paste(main_path, "/r-extractions/example-set.R", sep = ""))

run_analysis <- function(file, program) {
  log <- read_build_log_from_file(file, sample_path)
  lines <- unlist(stri_split_lines(log, omit_empty = TRUE))

  examples <- get_exampleset(program)
  output_line_counts <- map(examples$output, function (x) str_count(x, "\n") + 1)
  avg_output_line_count <- mean(unlist(output_line_counts))

  return(join_extracted_lines(sample(lines, avg_output_line_count)))
}

run_random_selection_extraction <- function() {
  result <- run_analysis(file = opt_get("file"), program = opt_get("program"))
  cat(result)
}

run_random_selection_extraction()
