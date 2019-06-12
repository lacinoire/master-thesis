# Data collection for metamodel / example data

run the data collection with
TODO: test: setup necessary?

``` console
bundle exec ruby collect-travis-logs.rb
```

This will write the considered repos to [`repos-to-analyze.txt`](repos-to-analyze.txt) and download logs from travis, saving them under a new folder `logs`

We collect logs from popular Github repositories that also use Travis CI. See [`config.yml`](config.yml) for more insight on the selection criteria 😃
