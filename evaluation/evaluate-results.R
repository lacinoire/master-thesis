suppressPackageStartupMessages({
  library(XML)
  library(methods)
  library(graphics)
  library(stringdist)
  library(ggplot2)
  library(svglite)
})

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"

## load other modules
source(paste(main_path, "/r-extractions/utilities.R", sep = ""))


# Convert the input xml file to a data frame.
getDataFrameForPBEResultsFile <- function(path) {
  oldw <- getOption("warn")
  options(warn = -1)
  
  setwd(paste(main_path, "/evaluation/results/pbe", sep = ""))
  xml <- xmlTreeParse(file = path)
  
  data <- empty_results_data_frame()
  
  results <-
    xml[["doc"]]$children$EvaluationResultOfString[["Results"]]
  
  for (i in seq_along(1:length(results))) {
    item <- results[[i]]
    exampleCount <- length(item[["key"]][[1]][["Examples"]])
    
    test <- item[["value"]][[1]][[1]]
    learnedProgram <- xmlValue(test[["LearnedProgram"]][[1]])
    testInputPath <- xmlValue(test[["TestInputPath"]][[1]])
    testOutput <- xmlValue(test[["Output"]][[1]])
    desiredTestOutput <-  xmlValue(test[["DesiredOutput"]][[1]])
    accuracy <- 3
    iou <- 5
    successful <-  as.logical(xmlValue(test[["Successful"]][[1]]))
    learningDuration <-
      nanosecsToTime(as.numeric(xmlValue(test[["LearningDuration"]][[1]])))
    applicationDuration <-
      nanosecsToTime(as.numeric(xmlValue(test[["ApplicationDuration"]][[1]])))
    allKeywords <- xmlValue(test[["AllKeywords"]][[1]])
    searchKeywords <- select_keywords_to_search(allKeywords)
    categories <- xmlValue(test[["Categories"]][[1]])
    testInputLineCount <- xmlValue(test[["TestInputLineCount"]][[1]])
    testCategory <- xmlValue(test[["TestCategory"]][[1]])
    
    data = rbind(
      data,
      data.frame(
        ExampleCount = exampleCount,
        LearnedProgram = learnedProgram,
        TestInputPath = testInputPath,
        TestOutput = testOutput,
        DesiredTestOutput = desiredTestOutput,
        Accuracy = accuracy,
        IoU = iou,
        Successful = successful,
        LearningDuration = learningDuration,
        ApplicationDuration = applicationDuration,
        SearchKeywords = searchKeywords,
        AllKeywords = allKeywords,
        Categories = categories,
        TestInputLineCount = testInputLineCount,
        TestCategory = testCategory,
        ContextSizeFactor = 1,
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
      grepl(testOutput, desiredTestOutput, fixed = TRUE)
    data[row, "Successful"] <- as.logical(successful)

    accuracy2 <- 0
    if (nchar(testOutput) < 55000 && nchar(desiredTestOutput) < 55000) {
      accuracy2 <- stringsim(testOutput, desiredTestOutput)
    } else {
      accuracy2 <- -1
    }

    data[row, "Accuracy"] <- accuracy2

    testOutputLines <- stri_split_lines1(testOutput)
    desiredTestOutputLines <- stri_split_lines1(desiredTestOutput)
    intersection_over_union <- length(intersect(testOutputLines, desiredTestOutputLines))/length(union(testOutputLines, desiredTestOutputLines))

    data[row, "IoU"] <- intersection_over_union
  }
  return(data)
}

save_evaluation_result <- function(result, program_name, technique, selection, learning_step_count, test_count) {
  result <- calculate_accuracy(result)
  print(technique)
  message(paste0(main_path, "/evaluation/results/", technique))
  setwd(paste0(main_path, "/evaluation/results/", technique))
  results_file_name <- evaluation_identification(technique, gsub("/", "@", program_name), selection, learning_step_count, test_count)

  write.csv(
    transform(result,
    LearningDuration = format(LearningDuration, "%M.%OS3"),
    ApplicationDuration = format(ApplicationDuration, "%M.%OS3")
    ), file = paste0(results_file_name, ".csv"))

  return(result)
}

plot_evaluation_result <- function(result, program_name, technique, selection, learning_step_count, test_count) {
  result <- calculate_accuracy(result)
  plot_data <-
    result[c("ExampleCount",
             "Accuracy",
             "LearningDuration",
             "ApplicationDuration")]
  # print(str(plot_data))
  
  # learning_time_num <- as.numeric(plot_data$LearningDuration)
  # labels <- pretty(plot_data$LearningDuration, n = nrow(plot_data))
  plot(plot_data)
  title <- paste(program_name, selection, "Example Selection using", technique, sep = " ")
  p <-
    ggplot(data = plot_data,
           aes(x = plot_data$ExampleCount,
               y = plot_data$LearningDuration)) +
    geom_point(aes(size = plot_data$Accuracy)) +
    labs(
      title = "Log Extraction Evaluation",
      y = "Learning Duration",
      x = "Example Count",
      subtitle = title,
      caption = " "
    ) +
    scale_y_datetime(breaks = seq(
      from = min(plot_data$LearningDuration),
      to = max(plot_data$LearningDuration),
      by = (max(plot_data$LearningDuration) - min(plot_data$LearningDuration)) / 5
    ),
    date_labels = "%M min %OS3 sec") +
    scale_size(
      name = "Accuracy",
      labels = function(x) {return(x)}
    )
  # scale_color_gradient(
  #   low = "black",
  #   high = "cyan",
  #   breaks = as.integer(labels),
  #   labels = format(as.POSIXct(labels, origin = "1970-01-01", tz = "UTC"), "%OS3 sec")
  # )
  # scale_x_datetime(date_labels = "%M min")
  
  quartz()
  plot(p)
  message("-------- press return to close plot --------")
  invisible(readLines("stdin", n = 1))

  setwd(paste0(main_path, "/evaluation/results/", technique))
  results_file_name <- evaluation_identification(technique, gsub("/", "@", program_name), selection, learning_step_count, test_count)
  # ggsave(paste0(results_file_name, ".svg"), p)

  write.csv(
    transform(result,
    LearningDuration = format(LearningDuration, "%M.%OS3"),
    ApplicationDuration = format(ApplicationDuration, "%M.%OS3")
    ), file = paste0(results_file_name, ".csv"))

  return(result)
}
