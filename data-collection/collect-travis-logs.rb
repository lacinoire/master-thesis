#!/usr/bin/env ruby

require 'travis'

if __FILE__ == $0
  repo = Travis::Repository.find('FreeCodeCamp/freecodecamp')
  puts repo
end