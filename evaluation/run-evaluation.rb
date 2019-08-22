# run the various evaluation tasks

program = "BuildFailureReason/C/git@git"
selection = "random"
test_count = 1
learning_step_count = 5

run_ir_eval = "Rscript ../r-extractions/information-retrieval.R evaluate --program #{program} --selection #{selection} --test-count #{test_count} --learning-step-count #{learning_step_count} --verbose"

command_to_run = run_ir_eval

puts "running '#{command_to_run}'"
puts `#{command_to_run}`
