# What I will write about in my thesis

## Introduction
_motivation_  
CI widely used now - build logs valuable data source - only when you can extract wanted information - so many techniques to choose from - support choosing  
_this work_  
characterize extraction techniques and use cases - evaluate / show on 3 techniques: prose, text similarity, keyword search - the failing build logs data set - study on suitability - recommendation for the 3 focus techniques - results  
_research questions_  
RQ1: Is Programming by Example suited to extract information from CI build logs?  
RQ2: What criteria influence the suitability of an information extraction technique for CI build logs?  
RQ3: When are text similarity or keyword search better suited for information extraction from CI build logs?  
_contributions_  
...  
_structure overview_  
...  


## Related Work
(quite similar to what we already have)

### Continuous Integration Research

### Build Log Analysis and Augmentation

### Production Log Analysis
differentiate from works like logpai

### Information Extraction and Retrieval Techniques

### Program Synthesis by Example


## Information Extraction Techniques

### Characteristics of a Build Log
their specific semi-structuredness

### Model for Information Extraction Techniques
model = making a picture with boxes to visualize what we are talking about  
describing characteristics of extraction techniques - e.g. precision, needed configuration, time performance

### Model for Extraction Tasks from Build Logs
clearly describing use cases where one wants to extract information from build logs - e.g. usage of the output, duration requirements  
answer RQ about what influences suitability of a technique  

### Model for Extractable Information in Build Logs
→ old metamodel - what information is in build logs that one might want to extract?

### PROSE Regular Expression Program Synthesis
for all techniques: explain how they work & express as instantation of model

### Text Similarity

### Simple Keyword Search

### Further Techniques
e.g. diffing with successful log

## The Failing Build Logs Data Set

### Motivation
why did we create it - what does it enable (for us & others)

### Log Collector
the tool built

#### Sampling Repositories
from ghtorrent

#### Sampling Builds
from TravisCI -  stratified wrt. state (failed/errored/...)

#### Sampling Logs
select log files for builds

### Log Collection Process
instantiation of above: collected 30 langs / 3 repos / 10 failed logs  
for initial exploration: 30 langs / 3 repos / 3 logs per state

### Labeling
explanation & labeling process for the data points we have

#### Build Failure Reason
realistic information devs want to know - not specifically chosen to be easily extractable by prose

#### Keywords
for simple keyword search - imitate what users would search for ad-hoc

#### Categories
quantifying the "examples need to be sufficiently structurally similar" assumption

### Validation of our Data Set

#### Inter-rater Reliability
re-labeling of parts of the labels - cohen's kappa

#### Sending Mails out to developers
study description & results

## Our Information Extraction Tool
implementation description of the techniques mentioned in "Information Extraction Techniques" - tech stack / in-output / learnings

### Common Interface
mainly CLI explanation - showing usage

### PROSE Program Synthesis

### Text Similarity

### Simple Keyword Search

### Random

## Technique Comparison Study
running evaluation to compare the different techniques

### Study Design
taking The Failing Build Log Data Set - run 3(4 with random) techniques with increasing example count - mesuring xyz - justify choices like running chronologically / testing on 1 example / no k-fold validation

### Study Results
discuss plain results - graphs

### Resulting Reccomending Scheme
interpret results - when should PROSE be used? - when should text similarity be used? - when should keyword search be used? - answer RQ about PROSE & other techniques

## Conclusion
wrap-up

### Future Work
extend analysis with further techniques - use data set & analysis to improve our 3 techniques  
