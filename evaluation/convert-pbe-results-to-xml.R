#!/usr/bin/env Rscript

suppressPackageStartupMessages({
  library(optigrab)
})

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"

## load other modules
source(paste(main_path, "/evaluation/evaluate-results.R", sep = ""))

file <- opt_get_verb()
name_parts <- strsplit(file, "-", fixed = TRUE)[[1]]
end <- length(name_parts)
print(name_parts)
print(end)

data <-
  getDataFrameForPBEResultsFile(file)

result <- save_evaluation_result(data, paste(name_parts[1:(end - 4)], collapse = "-"), name_parts[[end - 3]], name_parts[[end - 2]], name_parts[[end - 1]], gsub(".xml", "", name_parts[[end]]))