# Collecting Travis CI Logs from popular GitHub repositories

Welcome to our tool for stratifiedly sampling Travis CI build logs from popular GitHub repositories identified by GHTorrent.

Run

``` console
bundle install
```

beforehand to install all dependencies. We use Ruby 2.6.3.

Look into [config.yml](config.yml) in order to configure the data collection. Also add your Travis API-Key under "auth".

Then run the data collection with

``` console
bundle exec ruby collect-travis-logs.rb all
```

If you do not want to select popular repositories from GHTorrent, but rather collect only for one repository, provide the programming language (used as folder name to structure the saved repositories/logs) and the respository slug (replacing `/` with `@` to not interfere with paths):

``` console
bundle exec ruby collect-travis-logs.rb <language> <slug>
```

``` console
bundle exec ruby collect-travis-logs.rb Swift vsouza@awesome-ios
```

The tool will download the logs, saving them under a new folder `logs-<config-data-description>`.

We used a stratified sampling approach to collect about two logs for each build states of those repositories, inspecting only the newest `try_count` builds per repository.

Sampling repositories for 30 languages, with max. 3 repos each and trying through the 15 most watched ones yields [this](repos-to-analyze-120619.txt) list of repositories. The obtained logs were then used to build the Build-Log-Information-Meta-Model and select interesting repositories/logkinds to use as data samples for the evaluation.
