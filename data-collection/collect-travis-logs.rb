#!/usr/bin/env ruby

require 'travis'
require 'csv'
require 'httparty'
require 'google/cloud/bigquery'

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

class GHTorrentParser
  def self.get_popular_languages()
    bigquery = Google::Cloud::Bigquery.new# project: "nutrimon-61d83"
    sql = "select t.language, count(*)
    from (select u.login, p.name, p.language, count(*)
    from `ghtorrent-bq.ght_2018_04_01.projects` p,`ghtorrent-bq.ght_2018_04_01.users` u, `ghtorrent-bq.ght_2018_04_01.watchers` w
    where
        p.forked_from is null and
        p.deleted is false and
        w.repo_id = p.id and
        u.id = p.owner_id
    group by p.id, u.login, p.name, p.language
    having count(*) > 50
    order by count(*) desc) t
    where t.language is not null
    group by t.language
    order by count(*) desc
    limit 30"
    data = bigquery.query sql
    data
  end
end

if $0 == __FILE__
  Travis.access_token = 'wnjJqxnQHvEnxu_ZI5bAXA'
  table = CSV.read('most_watched_popular_languages.csv', headers: true)

  #repo_id = HTTParty.get('https://api.travis-ci.org/repo/FreeCodeCamp%2Ffreecodecamp',
  #                       headers: headers)
  #                  .response.to_hash
  #puts repo_id#['default_branch']['name']
  #puts LogCollector.get_latest_log('FreeCodeCamp%2Ffreecodecamp')
  puts GHTorrentParser.get_popular_languages
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
