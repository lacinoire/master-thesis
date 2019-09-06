<!-- <script src="https://gist.github.com/pierrejoubert73/902cc94d79424356a8d20be2b382e1ab.js"></script> -->
<md-style name="github"></md-style>

# How we (will) collect samples and validate them

Describing the labeling & validation we conduct(ed) for the evaluation of the build log dataset we  collected.

## Dataset
We queried GHTorrent for the 30 most popular languages and for each picked the top three popular repositories which also used Travis CI.
From these 86 repositories we each collected 10 build logs categorized as "failed" by Travis CI.
One repository had only a single "failed" log, and for two others all the logs were only "null".
After excluding those we were left with a dataset of 83 repositories with 10 log files each.

## Build Failure Reason

For each of the logs in our dataset we labeled which substring of the log file describes "the reason the build failed".
This could be for example the lines describing which test failed during the testing phase or the characters describing the compiler error.
The possible (it is not present in every repo in our samples) broadness of the "build failure reason" comes from the fact, that failures in various stages of the build process are still all categorized as "failed" in Travis CI.

<details>
  <summary>Some examples of Build Failure Reasons from out data set</summary>

[C++/bitcoin@bitcoin/failed/567118690.log](../tool/samples/C++/bitcoin@bitcoin/failed/567118690.log)
```
src/test/test_framework/util.h seems to be missing the expected include guard:
#ifndef BITCOIN_TEST_TEST_FRAMEWORK_UTIL_H
#define BITCOIN_TEST_TEST_FRAMEWORK_UTIL_H
...
#endif // BITCOIN_TEST_TEST_FRAMEWORK_UTIL_H
        
        ^---- failure generated from test/lint/lint-include-guards.sh
```

[CSS/jgthms@bulma/failed/373686035.log](../tool/samples/CSS/jgthms@bulma/failed/373686035.log)
```
Error: Invalid CSS after ""sass/flex/_all" ": expected media query list, was "/*! it was call..."
on line 7 of bulma.sass
```

[PHP/composer@composer/failed/567101801.log](../tool/samples/PHP/composer@composer/failed/567101801.log)
```
PHP Fatal error:  Class 'Composer\Util\Response' not found in /home/travis/build/composer/composer/src/Composer/Util/RemoteFilesystem.php on line 286
```

[PHP/composer@composer/failed/547576002.log](../tool/samples/PHP/composer@composer/failed/547576002.log)
```
1) Composer\Test\DependencyResolver\SolverTest::testUnsatisfiableRequires
Failed asserting that two strings are equal.
--- Expected
+++ Actual
@@ @@
  - It's a private package and you forgot to add a custom repository to find it
+ - It's a private package and you forgot to configure the required authentication credentials
 
 Read <https://getcomposer.org/doc/articles/troubleshooting.md> for further common problems.'

/home/travis/build/composer/composer/tests/Composer/Test/DependencyResolver/SolverTest.php:717
```

[CSS/twbs@bootstrap/failed/566773003.log](../tool/samples/CSS/twbs@bootstrap/failed/566773003.log)
```
ERROR[39m
Disconnected, because no message in 30000 ms.
        Chrome Mobile 74.0.3729 (Android 8.0.0) ERROR
Disconnected, because no message in 30000 ms.
        Chrome Mobile 74.0.3729 (Android 8.0.0): Executed 0 of 0[31m DISCONNECTED[39m (30.001 secs / 0 secs)
        [91m02 08 2019 03:17:08.751:ERROR [reporter.browserlabs]: [39m✖ Test Disconnected
```

</details>

### Labeling DONE ALREADY (xml escapeing fixes still ToDo)

We labeled the first occuring substring describing the failure. If there were multiple errors described we took the first continuous block of error description.

Process: read through build log and copy out desired substring. make sure the xml text editor (with the file containing the labeled data) does no automated formatting.
later: cleanup and escaping xml special characters

### Validation NOT DONE

To validate this there would be two approaches:

#### Simple inter-rater reliability validation

- we give a part of the same labeling task to someone else (moritz, annibale, martijn (aka some master student)?) TODO: HOW MANY? MAGIC 27?
- compare labels and compute Cohens Kappa to be sure that it is good enough (https://de.wikipedia.org/wiki/Interrater-Reliabilit%C3%A4t https://de.wikipedia.org/wiki/Cohens_Kappa)

#### Asking the actual developers

- for every build we sampled look up the corresponding commit on GitHub
- if an e-mail is linked to it, we send a mail there asking for whether the labeling was correct

> Hey {name of developer we hopefully extract from the commit / github}!
>
> We (link / explanation?) are studying different tools to extract information form Travis CI build logs. Because {proejct name} is one of the most popular {language} projects on GitHub and uses Travis CI, we included some of your logs in the data we want to use for our evaluation :)
>
>Would you take a few minutes to tell us wheter we understood correctly why a certain {project name} build failed?
>You authored commit {commit id} on the {date} which lead to the failed build {buildid, linked to Travis CI}.
>
>We believe this is the reason it failed:
>{ show extraction + some lines of context}
>
>[Correct!] // linking something to a tiny survey in google forms to track in a google spreadsheet
>[No! let me tell you why it actually failed.] // link to a survey where they can copy in what they believe is the actual build failure reason
>
>If you are not sure you can find the whole log [here] on Travis CI.

- in the longer survey (for "No!", "yes" just should be completed directly and show the "thank you page" only):
  >Thanks a lot that you want to give us some deeper feedback! // already track click without completing the survey!
  >
  >We looked a build {id} and believed that it failed for this reason:  
  >{our labeled part}  
  >Though you said we are wrong?  (no actually you were right // linked to the yes part)  
  >
  >Would you go to the whole build log [here // alternative: put it in there directly], scroll to the part describing the actual reason the build failed and copy-paste that part back here?:  
  >{big text field}  
  >Wanna tell us why this one is correct?  
  >{free text field}
  >
  >[Send] -> thank you page
- gdpr thing and how we will use the data. will we save the mails of people who responded? (they probably can be inferred from the data anyway)

## Search Keywords

One ad-hoc developers can use to find information relevant to them is searching for keywords within the document.
We would like to research how good this approach is compared to the more complicated ones of prose synthesis & ir similarity.

### Labeling NOT DONE

- Look at X labeled samples & their context ("error" often appears _around_ the actual description of what went wrong (<- "error" might only be in the context and not directly the labeled substring))

  TODO: set size of context fixed: e.g. 5 or 10 lines. can we justify a number scientifically?

- take like 30 secs (maybe dependent on how big X is?) and come up with 1-3 keywords you would search for to find the given texts with the file

**→ what is X?**

#### version A
If we say fixed we only evaluate in timely order of builds (always learn from old builds for newer ones) then we could work here with 1/2/3/... labeled logs that are shown to the labeling person. We show those logs as supporting inspiration for the labeler to be closer to reality - a developer in a project would typically know the structure / error indicating words in their build logs.
#### version B
We look at all the samples in total an label a set of keywords for the whole example-set (one completed repository). Less work, but the downside would be that we cannot do the as nice comparsion over the number of examples use to teach that method.
#### version C
We label keywords only for single build log substrings, so look at all the examples separately. If we then "learn from various examples" we could take the 3 top-common keywords in the samples used for learning.
#### orthogonal version D
Here we could also sneakily put in a "learning from 0 examples" by extracting with around 3 keywords we feel are common for build logs overall.

### Validation NOT DONE

Same as simple inter-rater reliability validation for the BuildFailureReason.

Here we could maybe also do something with mTurk later.

<details>
  <summary>Notes on mTurk</summary>
  
  [Article on working for mTurk](https://www.theatlantic.com/business/archive/2018/01/amazon-mechanical-turk/551192/): Requesters pay on average 11€ / hour on task, important that time-to-complete estimate is correct/not underestimating!, take idle-time while looking for tasks & webpage loading into account for humane pay

  [Offical pricing documentation](https://requester.mturk.com/pricing): Worker reward is decided by requester, 20% fee to amazon (additional 20% when 10 assignments or more per task), minimum $0.01 per assignment, bonus for good work possible, premium qualification "Employment Industry - Software & IT Services": $0.40, "Job Function - Information Technology": $0.40

  [Paper about other SE reachers experience with mTurk](https://ieeexplore.ieee.org/document/6681365): paying more yields better turnout, though $30/hour IT salary seems not to be necessary, data should be validated to avoid simple clickers though rejecting submissions gives bad rating for requester so care should be applied, tests for subject screenings are sufficiently available

  [Survey about mTurk workers & their computer science background / suitability for studies](https://ieeexplore.ieee.org/document/7809392): sample consistency has significat differences → necessity to run tsudies using multiple study samples, 30% of particpants answered at least one question inconsistently (they asked questions multiple times to the same people), most workers payment driven, 24% with CS/IT background

  [nice paper explaining how HITs are built up and some techniques](https://pdfs.semanticscholar.org/4922/fc941be374c09ab0c432466e7da52747b872.pdf)  
  [some slides with insights about another CS survey](https://kstolee.github.io/presentations/esem2010slides.pdf)

  **Sketch:** (labeling keywords, version C (each labeled extraction separately))
  - start the HIT (Human Intelligence Task) with a small description of the task upfront with 1/2 examples. Showing samples & context + possible keywords that fit (should we also give access to the whole file?)  
  might take about 2 mins to read
  - assignment: give a sample & context and ask for 1-3 good keywords  
  give 8 tasks for each introduction (even & two more means paying more to amazon)  
  give 30 seconds to complete each assignment (excluded loading time (can you configure that?), if whole file is given as context maybe double?)  
  // maybe paying more or combining several labels in examples is useful here to turn down introduction time
  - total: 6 minutes. with $11/hour this would mean offering $1.1 to the workers, paying $1.32 + eventual premium qualification fees in total
  - for labeling keywords, version C in total we would need 83*10 assignments, so 315 HITs, costing $415.8 if we give each labeling task once
  -> papers suggest that it is useful to give tasks to multiple workers for quality control

</details>

## Build Failure Reason Categorization

From reading a lot about PROSE and the tests we ran already we have the intuition that PROSE will fail on learning an extraction task if the samples provided are structurally so different from each other that the learned regular expression would have to contain (multiple?) `OR` operators on the uppermost level.  
Maybe this will similarly hold for the IR similarity extraction approach.

For an evaluation we have to grasp this "structural differences" in data.  
Proposal: Group / categorize labeled extractions into '(structurally) same location in build log'/'same build stage that failed'. These will be relative to one repository / one group will not be transferrable from one repository or another.  
For those groupings / categorizations we are _not_ looking for "test failure" / "compile failure" here! It is meant relative to other samples from the same repository, so just integers as group identifiers would suffice.  
E.g. for a java repository the build could fail on the compile stage with a error message from the java compiler, on the junit stage with a junit test failure message or during a selenium test with a selenium error message. These three would then most likely be three different categories, as all build failure reasons are represented in a different way in the build log :)

We could use this to shown that prose (and maybe ir as well?) works better if there is a kind of fine grained control over why the build failed / in which stage. In our dataset we looked at samples categorized as 'failed' by Travis CI (the most fine-grained categorization it provides?)

**Why do we not categorize "test failure" vs "compile failure"?** 
The approaches we are currently researching are still agnostic to what a possible future user would like to extract. We collected data and samples about the BuildFailureReason because this can be described as a common use case later, but still the user might want to extract different things such as build duration, linter changesets or warnings. We could also barely fix the categories beforehand because different test tools would fall into different categories when they present their failures differently. (we would need a new category for every test tool for example)

### Labeling NOT DONE

- go through a whole example set (look at labeled extraction + context) in order (so numbering of categories stays the same) and assign numbers for categories, using the same number if similar to one of the previously seen extractions in surrounding structure / semantic position within log file

### Validation NOT DONE

Same as simple inter-rater reliability validation for the BuildFailureReason.
we will need to do #magic-number many repositories here
