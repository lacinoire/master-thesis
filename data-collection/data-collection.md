# Data collection for metamodel / example data

run the data collection with

``` console
bundle exec ruby collect-travis-logs.rb
```

You might need to do a

``` console
bundle install
```

beforehand to install all dependencies. We use Ruby 2.6.3

This will write the considered repositories to `repos-to-analyze-<config-data-description>.txt` and download logs from travis, saving them under a new folder `logs-<config-data-description>`.

Sampling repositories for 30 languages, with max. 3 repos each and trying through the 15 most watched ones yields [this](repos-to-analyze-120619.txt) list of repositories.
We used a stratified sampling approach to collect about two logs for each build states of those repositories, inspecting only the newest 100 builds per repository. The obtained logs were then used to build the Builog-Information-Meta-Model and select interesting repositories/logkinds to use as data samples for the evaluation.

See [`config.yml`](config.yml) for more insight on the selection criteria 😃
