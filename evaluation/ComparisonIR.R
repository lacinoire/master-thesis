library(XML)
library(tm)
library(topicmodels)
library(jsonlite)
library(slam)
library(igraph)
library(stringr)
library(cluster)
library(snakecase)
library(stopwords)
library(NMOF)
library(xtable)

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"

## 1. load utility functions 
source(paste(main_path, "/evaluation/utilities.R", sep=""))
# source(paste(main_path, "/metaheuristics.R", sep=""))

## parse the analysis programs xml files
setwd(paste(main_path, "/pbe-extraction-buildlogs/ressources/analysis-programs", sep=""))

path <- 'android-failure-with-dependencies.xml'
xml <- xmlTreeParse(file = path)

examples <- data.frame(input_path = character(), output = character(), stringsAsFactors=FALSE)
exampleset <- xml[['doc']]$children$AnalysisProgramOfRegionAnalysisSessionString[['LearningData']][['Examples']]
sample_path <- paste(main_path, "/pbe-extraction-buildlogs/samples/", sep="")
for (i in seq_along(1:length(exampleset))){
  example <- exampleset[[i]]
  examples <- rbind(examples, data.frame(input_path=paste(sample_path, xmlValue(example[['InputPath']][[1]]), sep=''), output=xmlValue(example[['Output']][[1]])))
}
print(str(examples))

## 2. Set path to the dataset
# Todo: possibly change this -> we need (line based?) splitting of the files from the xml inputs
system <- "datasets/LANG"

output_path <- paste(main_path, "/evaluation/split_samples", sep="");

## 3. read the oracle
# Todo: so construct which values we acutally have to learn from -> which lines are actually in the labeled desired results
# duplicate_graph <- paste(system, "/bugrepo/duplicates.json", sep="");
# duplicate_graph <- oracle2graph(duplicate_graph)
# plot(duplicate_graph)

## 4. Set the path to the output directory
#file_output <- "results.csv"
files <- examples$input_path

## 5. split the main file (cataining all reports) in separate files (one for each report)
## separate by (lines? paragraphs? configurable?) useful to do different real _files_ here???
# 5.1 Create the folder where to save the (separated reports)
dir.create(output_path, showWarnings = FALSE)
# 5.2 Split reports in sub-files
split_document(files, output_path)

## 6. create the corpus with textmatrix
tdm <- pre_processing(output_path)

# 7. Apply tf-idf weighting schema
tdm2 <- weightSMART(tdm, "ntn")
tdm$v <- as.integer(round(tdm2$v))