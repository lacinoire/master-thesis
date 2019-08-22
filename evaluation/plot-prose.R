#!/usr/bin/env Rscript

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"

## load other modules
source(paste(main_path, "/evaluation/evaluate-results.R", sep = ""))

data <-
  getDataFrameForPBEResultsFile("android-failure-with-dependencies_ManualSelection.xml")

result <- plot_evaluation_result(data, "android-failure-with-dependencies", "manual")