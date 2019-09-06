# How we (will) collect samples and validate them

Describing the labeling we conducted for the evaluation of the build log dataset we  collected.

## Dataset
We queried GHTorrent for the 30 most popular languages and for each picked the top three popular repositories which also used Travis CI.
From these 86 repositories we each collected 10 build logs categorized as "failed" by Travis CI.
One repository had only a single "failed" log, and for two others all the logs were only "null".
After excluding those we were left with a dataset of 83 repositories with 10 log files each.

## Build Failure Reason

  Example to Moritz!

For each of the logs in our dataset we labeled which substring of the logfile describes "the reason the build failed".
This could be for example the lines describing which test failed during the testing phase or the characters describing the compiler error.
The possible broadness of the "build failure reason" comes from the fact, that failures in various stages of the build process are still all categorized as "failed" in Travis CI.


### Labeling DONE

We labeled the first occuring substring describing the failure. If there were multiple errors described we took the first continouous block of error description.
Process: read through bulidlog and copy out desired substring. make sure the xml text editor (with the file containing the labeled data) does no automated formatting.
later: cleanup and escaping xml special characters

### Validation NOT DONE

To validate this there would be two approaches:

#### Simple inter-rater reliability validation

- we give a part of the same labeling task to someone else (moritz, annibale, martijn?) HOW MUCH? MAGIC 27?
- compare labels and compute Cohens Kappa to be sure that it is good enough (https://de.wikipedia.org/wiki/Interrater-Reliabilit%C3%A4t https://de.wikipedia.org/wiki/Cohens_Kappa)

#### Asking the actual developers

- for every build we sampled look up the corresponding commit on GitHub
- if an e-mail is linked to it, we send a mail there asking for whether the labeling was correct

Hey {name of developer we hopefully extract from the commit / github}!
We (link / explanation?) are studying different tools to extract information form Travis CI build logs. Because {proejct name} is one of the most popular {language} projects on GitHub and uses Travis CI, we included some of your logs in the data we want to use for our evaluation :)

Would you take a few minutes to tell us wheter we understood correctly why a certain {project name} build failed?
You authored commit {commit id} on the {date} which lead to the failed build {buildid, linked to Travis CI}.

We believe this is the reason it failed:
{ show extraction + some lines of context}

[Correct!] // linking something to a tiny survey in google forms to track in a google spreadsheet
[No! let me tell you why it actually failed.] // link to a survey where they can copy in what they believe is the actual build failure reason

If you are not sure you can find the whole log [here] on Travis CI.

- in the longer survey (for "No!", yes just should be complete directly and show the "thank you page directly"):
  Thanks a lot that you want to give us some deeper feedback! // already track click without completing the survey!
  We looked a build {id} and believed that it failed for this reason:
  {our labeled part}
  Though you said we are wrong?  (no actually you were right // linked to the yes part)
  Would you go to the whole build log [here // alternative: put it in there directly], scroll to the part describing the actual reason the build failed and copy-paste that part back here?:
  {big text field}
  Wanna tell us why this one is correct?
  {free text field}
  [Send] -> thank you page
- gdpr thing and how we will use the data. will we save the mails of people who responded? (they probably can be inferred from the data anyway)

## Search Keywords

One ad-hoc developers can use to find information relevant to them is searching for keywords within the document.
We would like to research how good this approach is compared to the more complicated ones of prose synthesis & ir similarity.

### Labeling NOT DONE

- Look at X labeled samples & their context ("error" often appears _around_ the actual description of what went wrong (<- "error" might only be in the context and not directly the labeled substring))
- take like 30 secs (maybe dependent on how big X is?) and come up with 1-3 keywords you would search for to find the given texts with the file

what is X?
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

## Build Failure Reason Categorization

label diversity metric
group into '(sturcturally) same location in build log'/'same build stage that failed'
use this to shown that prose (and maybe ir as well?) works better if there is a kind of fine grained control over
not looking for "test failure" / "compile failure" here, only relative to other samples in same repo 

STRESS MORE THAT WE ARE NOT FIXED IN WHAT WE EXTRACT AND THE USER OF ALL OUR TECHNIQUES CAN STILL CHOOSE THAT

### Labeling NOT DONE

go through example set (whole is needed now! cause categories are only interesting of the different labeled bfr's relative to each other)
go through in order in a file and label just with numbers for categories, in order so numbers stay the same

### Validation NOT DONE

Same as simple inter-rater reliability validation for the BuildFailureReason.
we will need to do magic-number many repositories here
