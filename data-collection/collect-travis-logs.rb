#!/usr/bin/env ruby

require 'travis'
require 'csv'
require 'httparty'
require 'google/cloud/bigquery'
require 'yaml'
require 'fileutils'

# access to configurable constants
module Config
  def self.config
    YAML.load_file('config.yml')
  end
end

# retrieves Buildlogs using webrequests to the Travis API or the amazon servers
class TravisRequester
  include Config
  include HTTParty
  base_uri 'https://api.travis-ci.org/'
  format :json
  headers 'User-Agent' => 'bpe-buildlogs',
          'Travis-API-Version' => '3',
          'Authorization' => "token #{Config.config['auth']['travis_token']}"

  # download the content of a buildlog through the travis rest api v3
  def self.retrieve_log_travis(job_id)
    log = get("/job/#{job_id}/log", headers: headers.merge('Accept' => 'text/plain'), format: :text)
    log
  end

  # download the content of a buildlog through the amazon aws servers
  def self.retrieve_log_amazon(job_id)
    'downloading logs from amazon is not yet implemented'
  end

  # check whether a repository uses Travis CI
  def self.repository_active(slug)
    Travis::Repository.find(slug).active
  rescue Travis::Client::NotFound => _e
    false
  end

  # for a repository, collect builds categorized by build state
  def self.select_builds(repo_slug)
    repo = Travis::Repository.find(repo_slug)
    categorized_builds = {}
    build_count = 0

    repo.each_build do |build|
      if categorized_builds[build.state].nil?
        categorized_builds[build.state] = []
        puts build.state
      end
      if categorized_builds[build.state].length < Config.config['log_selection']['log_count_per_state']
        categorized_builds[build.state] << build
        build_count += 1
      end
      break if build_count >= Config.config['log_selection']['total_log_count']
    end

    categorized_builds
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

  def self.popular_languages(count)
    query File.read('popular-langs.sql')
      .gsub('?lang_count?', count.to_s)
  end

  def self.popular_repos_for_language(language, from, to)
    query File.read('popular-repos-for-language.sql')
      .gsub('?language?', language)
      .gsub('?rank-lower-bound?', from.to_s)
      .gsub('?rank-upper-bound?', to.to_s)
  end
end

# samples travis buildlogs from popular gh repositories
class LogCollector
  include Config

  # get the most watched repos for a language which also use Travis CI
  def self.active_repos(lang)
    start_index = 0
    batch_size = Config.config['repo_selection']['batch_size']
    active_lang_repos = []

    while active_lang_repos.length < Config.config['repo_selection']['repos_per_language'] \
      && start_index < Config.config['repo_selection']['repos_to_try_per_language']

      candidate_repos = GHTorrentParser.popular_repos_for_language(lang, start_index, (start_index + batch_size))
      candidate_repos.each do |repo|
        slug = "#{repo[:login]}/#{repo[:name]}"
        active = TravisRequester.repository_active(slug)
        active_lang_repos << slug if active && active_lang_repos.length < Config.config['repo_selection']['repos_per_language']
      end
      start_index += batch_size
    end
    active_lang_repos
  end

  # collect popular repos for popular languages on github
  def self.repos_to_analyze
    result_file = File.open('repos-to-analyze.txt', 'w')
    active_repos = {}
    languages = GHTorrentParser.popular_languages(Config.config['repo_selection']['languages'])
    languages.each do |lang_result|
      lang = lang_result[:language]
      puts "Current Language: #{lang}"
      result_file.puts(lang)

      active_repos[lang] = active_repos(lang)
      puts active_repos[lang]
      result_file.puts(active_repos[lang])
      result_file.puts('')
      puts ''
    end

    puts active_repos
    puts "language count: #{active_repos.keys.length}"
    # puts "count for travis enabled repos: #{active_repos.transform_values { |_, slugs| slugs.length }}"
    result_file.close
    active_repos
  end

  # collect logs from popular repos on github
  def self.collect_logs
    repos_per_lang = LogCollector.repos_to_analyze
    repos_per_lang.each do |lang, repos|
      repos.each do |repo_slug|
        p repo_slug
        builds_per_state = TravisRequester.select_builds(repo_slug)
        p builds_per_state
        builds_per_state.each do |state, builds|
          builds.each do |build|
            next if build.jobs.empty?

            job_id = build.jobs[0].id
            log = TravisRequester.retrieve_log_travis(job_id)
            directory_path = "logs/#{lang}/#{repo_slug.gsub('/', '@')}/#{state}"
            FileUtils.mkdir_p directory_path
            File.write(directory_path + "/#{build.id}.log", log)
            p directory_path + "/#{build.id}"
          end
        end
      end
    end
  end
end

if $PROGRAM_NAME == __FILE__
  # LogCollector.repos_to_analyze
  LogCollector.collect_logs
end
