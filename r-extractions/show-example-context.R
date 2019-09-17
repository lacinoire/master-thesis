#!/usr/bin/env Rscript

suppressPackageStartupMessages({
  library(dplyr)
  library(text2vec)
  library(optigrab)
})

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"
sample_path <<-
  paste(main_path, "/tool/samples", sep = "")

## load other modules
source(paste(main_path, "/r-extractions/utilities.R", sep = ""))
source(paste(main_path, "/r-extractions/example-set.R", sep = ""))


example_set <- opt_get_verb()
examples <- get_exampleset(example_set)

for (i in 1:nrow(examples)) {
  example = examples[i,]
  cat(paste0("-=-=-=-=-=--=-=-=-=-=-", "Example ", i, "-=-=-=-=-=--=-=-=-=-=-"))
  cat(paste0("\nInput path: ", example$input_path))
  cat("\n")
  cat(get_lines_containing_output(
    example[["input_path"]],
    sample_path,
    example$output, 
    only_output_lines = TRUE, 
    context_lines_count = 5, 
    visually_separate_context = TRUE, 
    split_into_lines = FALSE))
  cat("\n")
}
