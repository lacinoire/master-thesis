#!/usr/bin/env ruby

# cleaning up the master thesis data set for a nice logchunks package

# samples -> "logs" folder, remove misc folder, otherwise same

# example-sets -> "remove and just take buildfailurereason"

require 'nokogiri'
require 'fileutils'

if $PROGRAM_NAME == __FILE__
  langs = Dir.entries('./build-failure-reason').select { |lang| not lang.start_with?('.') }
  langs.each do |lang|
    repos = Dir.entries("./build-failure-reason/#{lang}").select { |lang| not lang.start_with?('.') }
    repos.each do |repo|
      xml = Nokogiri::XML(open("./build-failure-reason/#{lang}/#{repo}")) do |config|
        config.default_xml.noblanks
      end
      clean = Nokogiri::XML('', nil, "UTF-8")
      examples = xml.at 'Examples'
      clean.add_child(examples)

      single_examples = clean.search 'ExampleDataOfString'
      single_examples.each do |example|
        example.name = 'Example'
      end
      input_paths = clean.search 'InputPath'
      input_paths.each do |input|
        input.name = 'Log'
      end
      outputs = clean.search 'Output'
      outputs.each do |output|
        output.name = 'Chunk'
      end

      path = "./cleaned/#{lang}/#{repo}"
      dirname = File.dirname(path)
      unless File.directory?(dirname)
        FileUtils.mkdir_p(dirname)
      end
      File.write(path, clean.to_xml(:indent => 2))
    end
  end
end
