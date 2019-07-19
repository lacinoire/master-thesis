#!/usr/bin/env ruby

require 'optparse'
require 'ostruct'

class Optparser
  def self.parse(args)
    options = OpenStruct.new
    options.technique = :auto
    options.action = :auto
    options.example_set = ""
    
    # analyze options
    options.file_path = ""

    # evaluate options
    options.selection = :auto
    options.learning_step_count = 0
    options.test_count = 0
    # options.include_inputs = false

    ## TODO keyword options

    opt_parser = OptionParser.new do |opts|
      opts.banner = "Usage: ruby run-extraction.rb -a analyze -t <technique> -e <example_set> -p <path_to_file_to_analyze>\n" \
                    "       ruby run-extraction.rb -a evaluate -t <technique> -e <example_set> -s <selection_technique> -l <step_count_for_learning> -c <test_count>"
      
      opts.separator ""
      opts.separator "Specific options:"

      opts.on("-a", "--action ACTION", :REQUIRED, [:analyze, :evaluate], "Either run an extraction for a example set ('analyze') or run the whole evaluation of it ('evaluate')") do |action|
        options.action = action
      end

      opts.on("-t", "--technique TECHNIQUE", [:pbe, :ir, :keyword, :random], "The technique used for creating the extraction program (pbe, ir, keyword, random)") do |technique|
        options.technique = technique
      end

      opts.on("-e", "--example-set EXAMPLE_SET", "The filename of the example set to use") do |example_set|
        options.example_set = example_set
      end

      opts.on("-p", "--path PATH", "The path to the file to be analyzed") do |file_path|
        options.file_path = file_path
      end

      opts.on("-s", "--selection SELECTION", [:chronological, :random, :manual], "The example sequence selection technique to use for evaluation (chronological, random, manual (= like defined in file))") do |selection|
        options.selection = selection
      end

      opts.on("-l", "--learning-step-count COUNT", "How many steps with increasing example set size to do during evaluation") do |learning_step_count|
        options.learning_step_count = learning_step_count
      end

      opts.on("-c", "--test-count COUNT", "How many test files to evaluate the generated program in each learning step of the evaluation") do |test_count|
        options.test_count = test_count
      end

      opts.separator ""
      opts.separator "Common options:"

      # No argument, shows at tail.  This will print an options summary.
      # Try it and see!
      opts.on_tail("-h", "--help", "Show this message") do
        puts opts
        exit
      end
    end

    opt_parser.parse!(args)
    options
  end # parse()

end # class Optparser

if $PROGRAM_NAME == __FILE__

  options = Optparser.parse(ARGV)
  puts options
  puts ARGV

  # TODO
  print(
    case options.technique
    when :pbe
      %x(echo pbe)
    when :ir
      %x(echo ir)
    else
      %x(echo technique not yet supported)
    end
  )

end