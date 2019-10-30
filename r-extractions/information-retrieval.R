#!/usr/bin/env Rscript

# Extract information from build logs using information retrieval

suppressPackageStartupMessages({
  library(dplyr)
  library(text2vec)
  library(optigrab)
  library(purrr)
})

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"
sample_path <<-
  paste(main_path, "/tool/samples", sep = "")

## load other modules
source(paste(main_path, "/r-extractions/utilities.R", sep = ""))
source(paste(main_path, "/r-extractions/example-set.R", sep = ""))
source(paste(main_path, "/evaluation/evaluate-results.R", sep = ""))


run_analysis <- function(program, file) {
  examples <- get_exampleset(program)
  test <- data.frame(input_path = file, output = "", stringsAsFactors = FALSE)

  results <- run_learning_step(examples, test)
  return(results[1, "TestOutput"])
}

run_learning_step <- function(train_examples, test_examples, step_results) {
  
  start_time_learning <- Sys.time()
  
  # we collect all line which contain (parts)
  # of the output the extraction should yield
  # (defined in the training examples)
  train_lines <- get_ided_line_samples(train_examples)
  test_lines <-
    get_ided_line_samples(test_examples, only_output_lines = FALSE)
  step_results[1, "TestInputLineCount"] <- length(test_lines)
  total_lines <- rbind(train_lines, test_lines)
  
  prep_fun <- identity
  tok_fun <- word_tokenizer
  
  # token iterators
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
  # tfidf modified by fit_transform() call!
  dtm_train_tfidf = fit_transform(dtm_train, tfidf)
  
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
  
  # process the calculated similarities
  similarity_sums <- apply(test_train_similarity, 1, sum)
  sorted_similarity_sums <- sort(similarity_sums, decreasing = TRUE)

  # select the lines to count as extracted
  context_size_factor <- 1
  avg_output_line_count <- avg_output_line_count(train_examples) * context_size_factor

  filtered_similarity_sums <- sorted_similarity_sums[1:min(avg_output_line_count, length(sorted_similarity_sums))] 
  extracted_lines <-
    subset(test_lines, id %in% names(filtered_similarity_sums))
  step_results[1, "TestOutput"] <-
    join_extracted_lines(extracted_lines[["lines"]])
  step_results[1, "TestInputPath"] <- test_examples[1, "input_path"]
  step_results[1, "TestCategory"] <- test_examples[1, "category"]
  step_results[1, "ContextSizeFactor"] <- context_size_factor
  
  end_time_application <- Sys.time()
  step_results[1, "ApplicationDuration"] <-
    sys_timing_to_time(start_time_application, end_time_application)
  
  return(step_results)
}

run_ir_extraction <- function() {
  verb <- opt_get_verb()
  
  if (verb != "evaluate" && verb != "analyze") {
    ## default behaviour: evaluate
    run_evaluation(program = "android-failure",
                   selection = "manual",
                   include_inputs = FALSE,
                   test_count = 1,
                   learning_step_count = 3,
                   verbose = TRUE)
  } else {
    program <- opt_get("program")
    verbose <- opt_get("verbose", n = 0)

    if (verb == "evaluate") {
      run_evaluation(program = program,
                     selection = opt_get("selection"),
                     include_inputs = opt_get("include-inputs", n = 0),
                     test_count = as.integer(opt_get("test-count")),
                     learning_step_count = as.integer(opt_get("learning-step-count")),
                     verbose = verbose,
                     step_method = run_learning_step,
                     technique = "ir")

    } else if (verb == "analyze") {
      cat(run_analysis(program = program, file = opt_get("file")))
    }
  }
}

run_ir_extraction()
