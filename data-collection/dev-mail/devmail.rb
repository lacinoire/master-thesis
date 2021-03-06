#!/usr/bin/env ruby

require_relative '../collect-travis-logs'
require 'nokogiri'
require 'net/smtp'
require 'erb'
require 'ostruct'
require 'pp'

# fills the csv row with information about the labeled extraction data
def fill_extraction_data(row)
  xml = Nokogiri::XML(open("../tool/example-sets/BuildFailureReason/#{row['language']}/#{row['repo_slug']}.xml"))

  log_index = row['log_index'].to_i + 1
  # determine jobid from log: already in base csv for now
  # input_path = xml.at("//AnalysisProgramOfRegionAnalysisSessionString/LearningData/Examples/ExampleDataOfString[#{log_index}]/InputPath")
  # File.open("../tool/samples/#{row['language']}/#{row['repo_slug']}/failed/#{row['build_id']}.log") do |logfile|
  #   job_id = logfile.read.scan(/^Job id: (.*)$/i)
  #   if job_id.nil? || job_id[0].nil?
  #     pp job_id
  #     row['job_id'] = 'job_id_not_found'
  #   else
  #     row['job_id'] = job_id[0][0].to_i
  #   end
  # end

  output = xml.at("//AnalysisProgramOfRegionAnalysisSessionString/LearningData/Examples/ExampleDataOfString[#{log_index}]/Output").content
  output = output.lines[0, 1].join('') if output.lines.count > 1
  row['output'] = output

  jobs_url_job_id = row['job_id'] == 'job_id_not_found' ? 'builds/' + row['build_id'].strip : 'jobs/' + row['job_id'].strip
  row['jobs_url_job_id'] = jobs_url_job_id

  row
end

# fills the csv row with information about the build
def fill_build_data(row)
  build = TravisRequester.get_build_for_id(row['build_id'])
  row['repository_owner'], row['repository_name'] = build['repository']['slug'].split('/')
  row['commit_sha'] = build['commit']['sha']
  #row['commit_message'] = build['commit']['message']
  row['commit_date'] = build['commit']['committed_at']
  row['build_number'] = build['number']
  row
end

# fills the csv row with information about the committer who triggered the build
def fill_user_data(row)
  user = TravisRequester.get_commiter_for_build(row['build_id'])
  if user.nil?
    row['dev_name'] = 'no_user_found'
    row['email'] = 'no_user_found'
  else
    row['email'] = user['emails'].nil? || user['emails'][0].nil? ? 'no_mail_found' : user['emails'][0]
    row['dev_name'] = user['name'].nil? ? 'no_username_found' : user['name']
  end
  row
end

# sends a mail
def smail(to, txt)
  # smtp = Net::SMTP.new('srv23.dsbsrv.de', 25)
  # smtp.set_debug_output $stderr
  server = Net::SMTP.new('postout.lrz.de',
                         587)
  server.enable_starttls

  server.start('localhost',
               Config.config['email']['username'],
               Config.config['email']['password'], :plain) do |smtp|
    begin
      smtp.send_message(txt, 'carolin.brandt@tum.de', to)
      puts "[#{Time.now}] Sent email to #{to}"
    rescue => error
      puts error
      puts "[#{Time.now}] Cannot send email to #{to}"
    end
  end
end

# renders the mail template
def render_erb(template, locals)
  ERB.new(template).result(OpenStruct.new(locals).instance_eval { binding })
end



# sends out mails for all entries of the buildcsv
def send_mails
  number_to_word = {
    1 => 'one',
    2 => 'two',
    3 => 'three',
    4 => 'four',
    5 => 'five',
    6 => 'six',
    7 => 'seven',
    8 => 'eight',
    9 => 'nine',
    10 => 'ten'
  }

  csv = CSV.read('dev-mail/builds2.csv', headers: true)

  mail_groups = {}
  csv.each do |row|
    if mail_groups[row['email'].strip]
      mail_groups[row['email'].strip].push row
    else
      mail_groups[row['email'].strip] = [row]
    end
  end

  puts mail_groups.keys.count

  mail_groups.each do |mail, rows|
    next if ['no_mail_found', 'no_user_found'].include?(mail)
    next if rows[0]['language'] != 'xxx'

    mail_text = ''
    rows.each_with_index do |row, index|
      dev_name = row['dev_name'] == 'no_username_found' ? '' : row['dev_name'].strip
      jobs_url_job_id = row['job_id'] == 'job_id_not_found' ? 'builds/' + row['build_id'].strip : 'jobs/' + row['job_id'].strip
      replacement = {
        email: mail.strip,
        build_num: row['build_number'].strip,
        repo_name: row['repository_name'].strip,
        dev_name: dev_name.split(' ')[0]&.strip,
        commit_sha_short: row['commit_sha'].strip[0..7],
        commit_sha_long: row['commit_sha'],
        commit_date: Time.parse(row['commit_date']&.strip).httpdate,
        extraction: row['output'].strip,
        repo_owner: row['repository_owner'].strip,
        build_id: row['build_id'].strip,
        jobs_url_job_id: jobs_url_job_id,
        mail_count: number_to_word[rows.length],
        mail_index: index + 1
      }
      if index.zero?
        pre_text = render_erb(File.open('dev-mail/pre-templatemail.txt').read, replacement)
        mail_text += pre_text
      end
      text = render_erb(File.open('dev-mail/core-templatemail.txt').read, replacement)
      mail_text += text
    end
    post_text = File.open('dev-mail/post-templatemail.txt').read
    mail_text += post_text
    puts 'sent mail to ' + mail.strip + ' with language ' + rows[0]['language'] + ' and repo ' + rows[0]['repo_slug']
    smail(mail.strip, mail_text)
  end
end

if $PROGRAM_NAME == __FILE__

  if ARGV[0] == 'gen-csv'
    build_csv = CSV.read('dev-mail/builds.csv', headers: true)

    CSV.open('dev-mail/buildsoneline.csv', 'w') do |f|
      build_csv.each_with_index do |row, index|
        row = fill_user_data(row)
        row = fill_build_data(row)
        row = fill_extraction_data(row)
        f << build_csv.headers if index.zero?
        f << row
        if (index % 50).zero?
          f.flush
          puts index
        end
      end
    end
  elsif ARGV[0] == 'send-mails'
    send_mails
  elsif ARGV[0] == 'clean-csv'
    build_csv = CSV.read('dev-mail/builds2.csv', headers: true)
    CSV.open('dev-mail/builds-cleaned.csv', 'w') do |f|
      build_csv.each_with_index do |row, index|
        new_row = CSV::Row.new([], [])
        new_row['log_index'] = row['log_index']
        new_row['language'] = row['language']
        new_row['repo_slug'] = row['repo_slug']
        new_row['build_id'] = row['build_id']
        new_row['jobs_url_job_id'] = row['jobs_url_job_id']
        new_row['repository_owner'] = row['repository_owner']
        new_row['repository_name'] = row['repository_name']
        new_row['build_number'] = row['build_number']
        new_row['output'] = row['output']
        f << new_row.headers if index.zero?
        f << new_row
      end
    end
  end
end
