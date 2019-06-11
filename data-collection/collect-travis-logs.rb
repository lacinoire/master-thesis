#!/usr/bin/env ruby

require 'travis'
require 'csv'
require 'httparty'
require 'google/cloud/bigquery'

# retrieves Buildlogs using webrequests to the Travis API or the amazon servers
class TravisRequester
  include HTTParty
  base_uri 'https://api.travis-ci.org/'
  format :json
  headers 'User-Agent' => 'bpe-buildlogs',
          'Travis-API-Version' => '3',
          'Authorization' => 'token wnjJqxnQHvEnxu_ZI5bAXA'

  def self.retrieve_log_travis(job_id)
    repo = Travis::Repository.find(repo_slug)
    # default_branch = repo.default_branch.name # get("/repo/#{repo_slug}")['default_branch']['name']
    last_build_id = repo.last_build_id # get("/repo/#{repo_slug}/branch/#{default_branch}")['last_build']['id']
    job_id = get("/build/#{last_build_id}/jobs")['jobs'][0]['id']
    log = get("/job/#{job_id}/log", headers: headers.merge('Accept' => 'text/plain'), format: :text)
    log
  end

  def self.retrieve_log_amazon(job_id)
    ''
  end

  def self.repository_active(slug)
    Travis::Repository.find(slug).active
  rescue Travis::Client::NotFound => _e
    false
  end
end

# queries the ghtorrent dataset through the google bigquery API
class GHTorrentParser
  def self.query(sql)
    bigquery = Google::Cloud::Bigquery.new
    data = bigquery.query sql
    data
  end

  def self.repos_from_popular_languages
    query File.read('popular-lang-repos.sql')
  end

  def self.popular_languages
    query File.read('popular-langs.sql')
  end

  def self.popular_repos_for_language(language, from, to)
    query File.read('popular-repos-for-language.sql')
      .gsub('?language?', language)
      .gsub('?rank-lower-bound?', from.to_s)
      .gsub('?rank-upper-bound?', to.to_s)
  end
end

if $PROGRAM_NAME == __FILE__

  RESULTS_FILENAME = 'repos-to-analyze.txt'
  result_file = File.open(RESULTS_FILENAME, 'w')
  active_repos = {}
  languages = GHTorrentParser.popular_languages
  p languages
  languages.each do |lang_result|
    lang = lang_result[:language]
    puts "Current Language: #{lang}"
    result_file.puts(lang)
    start_index = 0
    batch_size = 5
    active_lang_repos = []

    while active_lang_repos.length < 3 && start_index < (3 * batch_size) # TODO: config count of searched repos
      candidate_repos = GHTorrentParser.popular_repos_for_language(lang, start_index, (start_index + batch_size))
      candidate_repos.each do |repo|
        p repo
        slug = "#{repo[:login]}/#{repo[:name]}"
        p slug
        active = TravisRequester.repository_active(slug)
        p active
        active_lang_repos << slug if active && active_lang_repos.length < 3
      end
      start_index += batch_size
    end

    active_repos[lang] = active_lang_repos
    puts active_lang_repos
    result_file.puts(active_lang_repos)
    puts ''
  end

  puts active_repos
  puts "language count: #{active_repos.keys.length}"
  # puts "count for travis enabled repos: #{active_repos.transform_values { |_, slugs| slugs.length }}"
  result_file.close
end
