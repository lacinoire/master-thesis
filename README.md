# master-thesis

Welcome to the thesis repo 😊

## Try it yourself!

``` shell
git clone git@github.com:lacinoire/master-thesis.git
```

``` shell
cd master-thesis/tool
```

``` shell
ruby run-extraction.rb -a analyze -t pbe -e travis-worker-short -p misc/facebookgo@rocks-strata/166107245.log
```

``` shell
ruby run-extraction.rb -a analyze -t ir -e travis-worker-short -p misc/facebookgo@rocks-strata/166107245.log
```

Find a more in-depth documentation of our extraction possibilities [here](tool/readme.md)!

[Learn what we can extract and not extract with PROSE synthesized programs.](docs/what-can-we-extract.md)

For documentation on the Programming by Example data extraction tool look at the [Readme](pbe-extraction-buildlogs/readme.md) in the tool implementation folder.

Our data collection is described [here](data-collection/readme.md) and implemented [here](data-collection/collect-travis-logs.rb)

You can find an overview on what I have worked on recently in the  [Worklog](docs/worklog.md)


Table of Contents for the repository:

- [Our unifying tool for the various extraction mechanisms](tool/readme.md)
- [Our Programming by Example information extraction tool](pbe-extraction-buildlogs/readme.md)
- [Various information extraction scripts: using information retrieval, keyword search, manually supplied regular expressions or random selection](r-extractions/readme.md)
- [Our tool to collect build logs samples of popular GitHub repositories from Travis CI](data-collection/readme.md)
- [Code for our evaluation of the different extraction techniques](evaluation/readme.md)
- [Our paper about this work](paper/readme.md)
- [My master thesis about this work](thesis/readme.md)
- [Worklog, an overview of information extractable by PBE and requirements for our tool unifying the different extractions](docs/index.md)
