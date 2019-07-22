# master-thesis

Welcome to the thesis repo 😊

## Try it yourself!

``` shell
> git clone git@github.com:lacinoire/master-thesis.git
> cd master-thesis/tool
> ruby run-extraction.rb -a analyze -t pbe -e travis-worker-short -p facebookgo@rocks-strata/166107245.log
> ruby run-extraction.rb -a analyze -t pbe -e travis-worker-short -p facebookgo@rocks-strata/166107245.log
```

Find a more in-depth documentation of our extraction possibilities [here](tool/readme.md)!

[Learn what we can extract and not extract with PROSE synthesized programs.](docs/what-can-we-extract.md)

For documentation on the Programming by Example data extraction tool look at the [Readme](pbe-extraction-buildlogs/Readme.md) in the tool implementation folder.

Our data collection is described [here](data-collection/data-collection.md) and implemented [here](data-collection/collect-travis-logs.rb)

You can find an overview on what I have worked on recently in the  [Worklog](docs/worklog.md)
