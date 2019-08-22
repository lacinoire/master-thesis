## loading the exampleset data

## load other modules
source(paste(main_path, "/r-extractions/utilities.R", sep = ""))

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
  
  file_content <- read_build_log_from_file(path, paste(
      main_path,
      "/tool/example-sets",
      sep = ""
    ))
  xml <- xmlTreeParse(file = file_content, asText = TRUE)
  
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
    output <- xmlValue(example[["Output"]][[1]])
    examples <-
      rbind(
        examples,
        data.frame(
          input_path = xmlValue(example[["InputPath"]][[1]]),
          output = output,
          stringsAsFactors = FALSE
        )
      )
  }
  return(examples)
}