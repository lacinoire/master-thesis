#!/usr/bin/env Rscript

# Just returning back random lines from the build log
suppressPackageStartupMessages({
  library(optigrab)
  library(stringi)
  library(purrr)
})

main_path <<- "/Users/Laci/Documents/Delft/master-thesis"
sample_path <<-
  paste(main_path, "/tool/samples", sep = "")

## load other modules
source(paste(main_path, "/r-extractions/utilities.R", sep = ""))
source(paste(main_path, "/r-extractions/example-set.R", sep = ""))
source(paste(main_path, "/evaluation/evaluate-results.R", sep = ""))

run_analysis <- function(file, examples) {
  log <- read_build_log_from_file(file, sample_path)
  lines <- unlist(stri_split_lines(log, omit_empty = TRUE))

  return(join_extracted_lines(sample(lines, min(avg_output_line_count(examples), length(lines)))))
}

run_random_extraction_step <- function(train_examples, test_examples, step_results) {
  start_time_learning <- Sys.time()
  avg_output_line_count <- avg_output_line_count(train_examples)
  step_results[1, "LearnedProgram"] <- paste(avg_output_line_count, collapse = ", ")

  end_time_learning <- Sys.time()
  step_results[1, "LearningDuration"] <- sys_timing_to_time(start_time_learning, end_time_learning)
  step_results[1, "TestInputPath"] <- test_examples[1, "input_path"]

  start_time_application <- Sys.time()

  output <- run_analysis(test_examples[1, "input_path"], train_examples)

  end_time_application <- Sys.time()
  step_results[1, "ApplicationDuration"] = sys_timing_to_time(start_time_application, end_time_application)

  step_results[1, "TestOutput"] <- output
  step_results
}

run_random_selection_extraction <- function() {
  verb <- opt_get_verb()

  if (verb == "analyze") {
    result <- run_analysis(file = opt_get("file"), examples = get_exampleset(opt_get("program")))
    cat(result)
  } else if (verb == "evaluate") {
    program <- opt_get("program")
    run_evaluation(program = program,
                   selection = opt_get("selection"),
                   include_inputs = opt_get("include-inputs", n = 0),
                   test_count = as.integer(opt_get("test-count")),
                   learning_step_count = as.integer(opt_get("learning-step-count")),
                   verbose = opt_get("verbose", n = 0),
                   step_method = run_random_extraction_step,
                   technique = "random")
  }
}

run_random_selection_extraction()
