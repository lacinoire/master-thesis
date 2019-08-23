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

You can find an overview on what I have worked on recently in the  [Worklog](docs/worklog.md)


Table of Contents for the repository:

- [Our unifying tool for the various extraction mechanisms](tool)
- [Our Programming by Example information extraction tool](pbe-extraction-buildlogs)
- [Various information extraction scripts: using information retrieval, keyword search, manually supplied regular expressions or random selection](r-extractions)
- [Our tool to collect build logs samples of popular GitHub repositories from Travis CI](data-collection)
- [Code for our evaluation of the different extraction techniques](evaluation)
- [Our paper about this work](paper)
- [My master thesis about this work](thesis)
- [Worklog, an overview of information extractable by PBE and requirements for our tool unifying the different extractions](docs/index.md)
