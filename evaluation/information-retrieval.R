#!/usr/bin/env Rscript

library(dplyr)
library(text2vec)
library(optigrab)

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"
sample_path <<-
  paste(main_path, "/pbe-extraction-buildlogs/samples", sep = "")

## load other modules
source(paste(main_path, "/evaluation/utilities.R", sep = ""))
source(paste(main_path, "/evaluation/example-set.R", sep = ""))
source(paste(main_path, "/evaluation/evaluate-results.R", sep = ""))

main <- function() {
  verb <- "evaluate"
  # anlayze options
  file <- "connectbot@connectbot/3.log"
  # common options
  program <- "android-failure"
  # evluate options
  selection <- "manual"
  include_inputs <- FALSE
  test_count <- 1
  learning_step_count <- 3
  if (verb == "analyze") {
    run_analysis(program, file)
  } else if (verb == "evaluate") {
    run_evaluation(program,
                   selection,
                   include_inputs,
                   test_count,
                   learning_step_count)
  } else {
    # print(opt_help())
  }
}

run_analysis <- function(program, file) {
  
}


run_evaluation <-
  function(program,
           selection,
           include_inputs,
           test_count,
           learning_step_count) {
    ## load example set
    path <- paste(program, ".xml", sep = "")
    examples <- get_exampleset(path)
    
    
    if (selection == "manual") {
      # do nothing with parsed examples
    } else if (selection == "random") {
      examples <- examples[sample(nrow(examples)), ]
    } else if (selection == "chronological") {
      examples <-
        examples[order(gsub(".*/(.*).log", "\\1", examples[, "input_path"])),]
    } else {
      print("selection has to be either 'manual', 'random' or 'chrononlogical'")
    }
    
    print(examples)
    
    results <- empty_results_data_frame()
    
    for (training_step in 1:learning_step_count) {
      ## select on which examples to train / test
      train_examples <- examples[c(1:training_step),]
      test_examples <-
        examples[c(training_step:training_step + test_count),]
      
      step_results <- run_learning_step(train_examples, test_examples)
      
      step_results[1, "ExampleCount"] <- training_step
      step_results[1, "DesiredTestOutput"] <- test_examples[1, "output"]
      
      results <- rbind(results, step_results)
    }
    
    print(str(results))
    plot_evaluation_result(results)
    setwd(paste(main_path, "/evaluation", sep = ""))
    write.table(results, file = "results/ir.txt")
  }

run_learning_step <- function(train_examples, test_examples) {
  step_results <- empty_results_data_frame()
  
  
  # we collect all line which contain (parts)
  # of the output the extraction should yield
  # (defined in the training examples)
  start_time_learning <- Sys.time()
  
  train_lines <- get_ided_line_samples(train_examples)
  test_lines <-
    get_ided_line_samples(test_examples, only_output_lines = FALSE)
  
  total_lines <- rbind(train_lines, test_lines)
  
  prep_fun <- identity
  tok_fun <- word_tokenizer
  
  it_total <-
    itoken(
      total_lines$lines,
      preprocessor = prep_fun,
      tokenizer = tok_fun,
      ids = total_lines$id
    )
  it_train <-
    itoken(
      train_lines$lines,
      preprocessor = prep_fun,
      tokenizer = tok_fun,
      ids = train_lines$id
    )
  it_test <-
    itoken(
      test_lines$lines,
      preprocessor = prep_fun,
      tokenizer = tok_fun,
      ids = test_lines$id
    )
  
  
  ## prepare vocabulary
  # todo n-grams?
  vocab <- create_vocabulary(it_total)
  pruned_vocab <-
    prune_vocabulary(
      vocab,
      term_count_min = 2,
      doc_proportion_max = 0.7,
      doc_proportion_min = 0
    )
  vectorizer <- vocab_vectorizer(pruned_vocab)
  
  dtm_train <- create_dtm(it_train, vectorizer)
  
  ## tf-idf transformation
  tfidf = TfIdf$new()
  # fit model to train data and transform train data with fitted model
  dtm_train_tfidf = fit_transform(dtm_train, tfidf)
  # tfidf modified by fit_transform() call!
  
  end_time_learning <- Sys.time()
  step_results[1, "LearningDuration"] = sys_timing_to_time(start_time_learning, end_time_learning)
  
  start_time_application <- Sys.time()
  dtm_test <- create_dtm(it_test, vectorizer)
  # apply pre-trained tf-idf transformation to test data
  dtm_test_tfidf  = create_dtm(it_test, vectorizer) %>%
    transform(tfidf)
  
  test_train_similarity <-
    sim2(dtm_test_tfidf,
         dtm_train_tfidf,
         method = "cosine",
         norm = "l2")
  
  #similarity_frame <- filter(as.data.frame(test_train_similarity), any_vars(. > 0))
  
  # print(dim(test_train_similarity))
  # print(test_train_similarity[1:2, 1:2])
  
  similarity_sums <- apply(test_train_similarity, 1, sum)
  filtered_similarity_sums <- similarity_sums[similarity_sums > 0.5]
  # print(head(similarity_sums))
  # print(str(filtered_similarity_sums))
  # print(head(filtered_similarity_sums))
  # avg <- mean(filtered_similarity_sums)
  # print(avg)
  # print(filtered_similarity_sums)
  # plot(filtered_similarity_sums)
  
  # print(names(filtered_similarity_sums))
  extracted_lines <-
    subset(test_lines, id %in% names(filtered_similarity_sums))
  
  # print(extracted_lines)
  # print(paste(extracted_lines["lines"], sep = "\n"))
  end_time_application <- Sys.time()
  step_results[1, "ApplicationDuration"] <-
    sys_timing_to_time(start_time_application, end_time_application)
  step_results[1, "TestOutput"] <-
    paste(extracted_lines["lines"], sep = "\n")
  return(step_results)
}

main()