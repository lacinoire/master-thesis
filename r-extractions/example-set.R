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
  xml <- xmlTreeParse(file = file_content, asText = TRUE, options = HUGE)
  
  examples <-
    data.frame(
      input_path = character(),
      output = character(),
      keywords = character(),
      category = integer(),
      stringsAsFactors = FALSE
    )
  exampleset <-
    xml[["doc"]]$children$AnalysisProgramOfRegionAnalysisSessionString[["LearningData"]][["Examples"]]
  for (i in seq_along(1:length(exampleset))) {
    example <- exampleset[[i]]
    output <- xmlValue(example[["Output"]])
    keywords <- xmlValue(example[["Keywords"]])
    if (keywords.endsWith(,))
      keywords <- paste0(keywords, " ")
    end
    examples <-
      rbind(
        examples,
        data.frame(
          input_path = xmlValue(example[["InputPath"]]),
          output = output,
          keywords = xmlValue(example[["Keywords"]]),
          category = xmlValue(example[["Category"]]),
          stringsAsFactors = FALSE
        )
      )
  }
  return(examples)
}

## returns a string which is a concatenation of the categories of the given examples
get_categories_chain <- function(examples) {
  return(paste(examples$category, sep = "-"))
}

## returns the list of all keywords of the given examples (with possibly duplicates)
get_keywords_chain <- function(examples) {
  print(examples$keywords)
  return(paste(examples$keywords, sep = ", "))
}
