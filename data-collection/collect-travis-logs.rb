#!/usr/bin/env ruby

require 'travis'
require 'csv'
require 'httparty'

class LogCollector
  include HTTParty
  base_uri 'https://api.travis-ci.org/'
  format :json
  headers 'User-Agent' => 'bpe-buildlogs',
          'Travis-API-Version' => '3',
          'Authorization' => 'token wnjJqxnQHvEnxu_ZI5bAXA'

  def self.get_latest_log(repo_slug)
    default_branch = get("/repo/#{repo_slug}")['default_branch']['name']
    last_build_id = get("/repo/#{repo_slug}/branch/#{default_branch}")['last_build']['id']
    job_id = get("/build/#{last_build_id}/jobs")['jobs'][0]['id']
    log = get("/job/#{job_id}/log", headers: headers.merge('Accept' => 'text/plain'), format: :text)
    log
  end
end

if $0 == __FILE__
  Travis.access_token = 'wnjJqxnQHvEnxu_ZI5bAXA'
  table = CSV.read('most_watched_popular_languages.csv', headers: true)

  #repo_id = HTTParty.get('https://api.travis-ci.org/repo/FreeCodeCamp%2Ffreecodecamp',
  #                       headers: headers)
  #                  .response.to_hash
  #puts repo_id#['default_branch']['name']
  puts LogCollector.get_latest_log('FreeCodeCamp%2Ffreecodecamp')
  return

  # identify repos that use Travis CI
  found_repos = []
  table.each do |row|
    slug = "#{row['login']}/#{row['name']}"
    begin
      repo = Travis::Repository.find(slug)
    rescue Travis::Client::NotFound => exception
      # puts "Travis Repo not found for: #{slug}"
    else
      if repo.last_build_number == nil
        # puts "Travis CI not activated for: #{slug}"
      else
        found_repos << repo
        puts slug
        puts "Last failing build: #{repo.last_build_number}"
        puts "\n"
      end
    end
  end

  # get logs
  found_repos.each do |repo|
    puts repo.slug
    job = repo.last_build.jobs.first
    puts job.id
    puts "\n"
    break
  end
end
