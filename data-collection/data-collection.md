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

This will write the considered repositories to [`repos-to-analyze.txt`](repos-to-analyze.txt) and download logs from travis, saving them under a new folder `logs`. Sampling repositories for 30 languages, with max. 3 repos each and trying through the 15 most watched ones yields [this](repos-to-analyze-120619.txt) list of repositories.

We collect logs from popular Github repositories that also use Travis CI. See [`config.yml`](config.yml) for more insight on the selection criteria 😃
