# Load the packages required to read XML files.
library(XML)
library(methods)
library(graphics)
library(stringdist)
library(ggplot2)

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"

## load other modules
source(paste(main_path, "/evaluation/utilities.R", sep = ""))


# Convert the input xml file to a data frame.
getDataFrameForResultsFile <- function(path) {
  oldw <- getOption("warn")
  options(warn = -1)
  
  setwd("/Users/Laci/Documents/Delft/master-thesis/pbe-extraction-buildlogs/results")
  xml <- xmlTreeParse(file = path)
  
  data <- empty_results_data_frame()
  
  results <-
    xml[["doc"]]$children$EvaluationResultOfString[["Results"]]
  
  for (i in seq_along(1:length(results))) {
    item <- results[[i]]
    exampleCount <- length(item[["key"]][[1]][["Examples"]])
    
    test <- item[["value"]][[1]][[1]]
    learnedProgram <- xmlValue(test[["LearnedProgram"]][[1]])
    testOutput <- xmlValue(test[["Output"]][[1]])
    desiredTestOutput <-  xmlValue(test[["DesiredOutput"]][[1]])
    accuracy <- 3
    successful <-  as.logical(xmlValue(test[["Successful"]][[1]]))
    learningDuration <-
      nanosecsToTime(as.numeric(xmlValue(test[["LearningDuration"]][[1]])))
    applicationDuration <-
      nanosecsToTime(as.numeric(xmlValue(test[["ApplicationDuration"]][[1]])))
    
    data = rbind(
      data,
      data.frame(
        ExampleCount = exampleCount,
        LearnedProgram = learnedProgram,
        TestOutput = testOutput,
        DesiredTestOutput = desiredTestOutput,
        Accuracy = accuracy,
        Successful = successful,
        LearningDuration = learningDuration,
        ApplicationDuration = applicationDuration,
        stringsAsFactors = FALSE
      )
    )
  }
  #print(results_set)
  options(warn = oldw)
  
  return(data)
}

calculate_accuracy <- function(data) {
  for (row in 1:nrow(data)) {
    testOutput <- data[row, "TestOutput"]
    desiredTestOutput <- data[row, "DesiredTestOutput"]
    
    successful <-
      grepl(escapeStringAsNotRegex(testOutput), desiredTestOutput)
    data[row, "Successful"] <- as.logical(successful)
    
    accuracy <- nchar(testOutput) / nchar(desiredTestOutput)
    accuracy2 <- stringsim(testOutput, desiredTestOutput)
    
    data[row, "Accuracy"] <- accuracy
  }
  return(data)
}

plot_evaluation_result <- function(result) {
  result <- calculate_accuracy(result)
  plot_data <-
    result[c("ExampleCount",
             "Accuracy",
             "LearningDuration",
             "ApplicationDuration")]
  print(head(plot_data))
  
  #plot(plot_data)
  p <-
    ggplot(data = plot_data,
           aes(
             x = plot_data$ExampleCount,
             y = plot_data$ApplicationDuration
           )) +
    geom_point(aes(col = plot_data$LearningDuration, size = plot_data$Accuracy)) +
    labs(
      subtitle = "",
      y = "application duration",
      x = "example count",
      title = "Scatterplot",
      caption = "android-failure manual example selection"
    ) +
    scale_y_datetime(breaks = seq(
      from = min(data$ApplicationDuration),
      to = max(data$ApplicationDuration),
      by = 0.04
    ),
    date_labels = "%OS3 sec")
  # scale_x_datetime(date_labels = "%M min")
  plot(p)
}

# #data <- getDataFrameForResultsFile("android-failure-with-dependencies_ManualSelection.xml")
# data <-
#   getDataFrameForResultsFile("android-failure-with-dependencies_ManualSelection.xml")

# plot_evaluation_result(data)
