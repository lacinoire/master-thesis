#!/usr/bin/env ruby

require 'fileutils'

# generate files that show the output + context (configured in r-extractions/show-example-context.R) for every example set.
# output to be found in the usual example-set name provided folder sturcture under 'example-set-outputs-with-context'

example_sets = File.readlines('eval-example-sets.txt')

example_sets.each do |example_set|
  example_set = example_set.strip

  file_path = "example-set-outputs-with-context/#{example_set}.txt"
  directory_path = file_path.rpartition('/').first
  puts directory_path
  FileUtils.mkdir_p directory_path
  output = `Rscript ../r-extractions/show-example-context.R #{example_set}`
  File.write(file_path, output)
end
