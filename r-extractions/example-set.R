## loading the exampleset data

## parse the analysis programs xml files
get_exampleset <- function(program) {
  setwd(
    paste(
      main_path,
      "/tool/example-sets",
      sep = ""
    )
  )
  path <- paste(program, ".xml", sep = "")
  
  xml <- xmlTreeParse(file = path)
  
  examples <-
    data.frame(
      input_path = character(),
      output = character(),
      stringsAsFactors = FALSE
    )
  exampleset <-
    xml[["doc"]]$children$AnalysisProgramOfRegionAnalysisSessionString[["LearningData"]][["Examples"]]
  for (i in seq_along(1:length(exampleset))) {
    example <- exampleset[[i]]
    examples <-
      rbind(
        examples,
        data.frame(
          input_path = xmlValue(example[["InputPath"]][[1]]),
          output = xmlValue(example[["Output"]][[1]]),
          stringsAsFactors = FALSE
        )
      )
  }
  return(examples)
}