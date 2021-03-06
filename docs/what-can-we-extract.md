# Possibilities and Limitations of Text Extraction with our Tool

_Most links go inside of the private respository, please ask if you want access. 😃_

_To try this yourself checkout the [build instructions](pbe-extraction-buildlogs/Readme.md)._

This document presents examples of the information or substrings our tool can and cannot extract from buildlogs.

## Travis-Worker Example

At the beginning of each buildlog, Travis mentions the machine which executes the build. In our metamodel of information in buildlogs we call this the `TravisWorker`. In our samples we find two representations of this information:

Short version: [`facebookgo@rocks-strata/166107245.log`](pbe-extraction-buildlogs/samples/facebookgo@rocks-strata/166107245.log), line 1

``` text
Using worker: worker-linux-docker-273f60df.prod.travis-ci.org:travis-linux-11
```

Long version: [`facebookgo@rocks-strata/190839612.log`](pbe-extraction-buildlogs/samples/facebookgo@rocks-strata/190839612.log), line 1-7

``` text
travis_fold:start:worker_info
[0K[33;1mWorker information[0m
hostname: ip-10-12-11-106:c287dce3-c64f-43d7-b455-af6557484127
version: v2.5.0-8-g19ea9c2 https://github.com/travis-ci/worker/tree/19ea9c20425c78100500c7cc935892b47024922c
instance: 4444508:travis:go
startup: 1.86043531s
travis_fold:end:worker_info
```

We can extract both by using separate synthesized programs:

``` bash
mono pbe-extraction-buildlogs/bin/Debug/pbe-extraction-buildlogs.exe analyze -f facebookgo@rocks-strata/166107245.log -p travis-worker-short
```

``` ocaml
Starting to learn program
Learning took 00:00:18.0688321
Learned Program:
let s = v in RegexRegion(s, "ε", "Alphanumeric◦Colon◦Alphanumeric", "ε", 1)

Starting to apply program
Applying took 00:00:00.0482345
Result of analyzing the file samples/facebookgo@rocks-strata/166107245.log with the program travis-worker-short:
  Analysis succeded.
  Output was: worker-linux-docker-273f60df.prod.travis-ci.org:travis-linux-11
```

``` bash
mono pbe-extraction-buildlogs/bin/Debug/pbe-extraction-buildlogs.exe analyze -f facebookgo@rocks-strata/190839612.log -p travis-worker-long
```

``` ocaml
Starting to learn program
Learning took 00:02:15.3592203
Learned Program:
let s = v in let s = PosToEndRegion(s, RegexPosition(s, RegexPair("ε", "Camel Case"), 1)) in StartToPosRegion(s, RegexPosition(s, RegexPair("WhiteSpace◦Alphanumeric", "Line Separator"), 1))

Starting to apply program
Applying took 00:00:00.0504247
Result of analyzing the file samples/facebookgo@rocks-strata/190839612.log with the program travis-worker-long:
  Analysis succeded.
  Output was: Worker information[0m
hostname: ip-10-12-11-106:c287dce3-c64f-43d7-b455-af6557484127
version: v2.5.0-8-g19ea9c2 https://github.com/travis-ci/worker/tree/19ea9c20425c78100500c7cc935892b47024922c
instance: 4444508:travis:go
startup: 1.86043531s
```

To look at the examples used for synthesizing these programs you can inspect the configuring `.xml` files in [`ressources/ressources/analysis-programs/`](pbe-extraction-buildlogs/ressources/analysis-programs).

Combining both examples into a unified exampleset was not successful. If you try to run the combined set on a file

``` bash
mono pbe-extraction-buildlogs/bin/Debug/pbe-extraction-buildlogs.exe analyze -f facebookgo@rocks-strata/166107245.log -p travis-worker
```

``` ocaml
Starting to learn program
Learning took 00:00:07.6217593
no program found
Result of analyzing the file samples/facebookgo@rocks-strata/166107245.log with the program travis-worker:
  Analysis succeded.
  Output was: no program found
```

you will see that the synthesis was not able to find a program.

*→ It could be that such an "OR" decision on the uppermost level is not possible with the PROSE porgram synthesis*

## Android failure

One example of extracting the reason for a build to fail is defined in the [`android-failure`](pbe-extraction-buildlogs/ressources/analysis-programs/android-failure.xml) exampleset.

This extracts the summarized reason for the builds from the project `connectbot@connectbot` to fail:

[`connectbot@connectbot/5.log`](pbe-extraction-buildlogs/samples/connectbot@connectbot/5.log), line 3933 - 3935

``` text
* What went wrong:
Execution failed for task ':app:connectedAndroidTest'.
> com.android.builder.testing.api.DeviceException: java.lang.RuntimeException: No connected devices!
```

You can test this extraction yourself:

``` bash
mono pbe-extraction-buildlogs/bin/Debug/pbe-extraction-buildlogs.exe analyze -f connectbot@connectbot/779.log -p android-failure
```

⚠️ Learning this program takes quite some time (I do not yet understand why), therefore executing this extraction will take a while (about 5 minutes on my machine) ⚠️ 

``` ocaml
Starting to learn program
Learning took 00:05:18.4873238
Learned Program:
let s = v in let s = PosToEndRegion(s, RegexPosition(s, RegexPair("ε", "\"Execution failed for task ':app:\""), 1)) in StartToPosRegion(s, RegexPosition(s, RegexPair("ε", "Line Separator◦Line Separator"), 1))

Starting to apply program
Applying took 00:00:00.2728715
Result of analyzing the file samples/connectbot@connectbot/779.log with the program android-failure:
  Analysis succeded.
  Output was: Execution failed for task ':app:testDebugUnitTest'.
> There were failing tests. See the report at: file:///home/travis/build/connectbot/connectbot/app/build/reports/tests/debug/index.html
```

Take a closer look at the program generated by this program synthesis:

``` ocaml
let s = v in let s = PosToEndRegion(s, RegexPosition(s, RegexPair("ε", "\"Execution failed for task ':app:\""), 1)) in StartToPosRegion(s, RegexPosition(s, RegexPair("ε", "Line Separator◦Line Separator"), 1))
```

This program fails on the following buildlog, which would also have to be included into the examples:

[`connectbot@connectbot/311.log`](pbe-extraction-buildlogs/samples/connectbot@connectbot/311.log), line 4077 - 4079

``` text
* What went wrong:
Could not determine the dependencies of task ':app:jacocoTestDebugReport'.
> Task with path 'testDebug' not found in project ':app'.
```

If this example is also added ([`android-failure-with-dependencies`](pbe-extraction-buildlogs/ressources/analysis-programs/android-failure-with-dependencies.xml)) the synthesized program changes to:

``` ocaml
let s = v in let s = PosToEndRegion(s, RegexPosition(s, RegexPair("Colon◦Line Separator", "ALL CAPS"), 1)) in StartToPosRegion(s, RegexPosition(s, RegexPair("ε", "Line Separator◦Line Separator"), 1))
````

``` bash
mono pbe-extraction-buildlogs/bin/Debug/pbe-extraction-buildlogs.exe analyze -f connectbot@connectbot/779.log -p android-failure-with-dependencies
```

⚠️ Learning this program takes quite some time (I do not yet understand why), therefore executing this extraction will take a while (about 5 minutes on my machine) ⚠️ 

``` ocaml
Starting to learn program
Learning took 00:22:50.4882860
Learned Program:
let s = v in let s = PosToEndRegion(s, RegexPosition(s, RegexPair("Colon◦Line Separator", "ALL CAPS"), 1)) in StartToPosRegion(s, RegexPosition(s, RegexPair("ε", "Line Separator◦Line Separator"), 1))

Starting to apply program
Applying took 00:00:00.4072661
Result of analyzing the file samples/connectbot@connectbot/779.log with the program android-failure-with-dependencies:
  Analysis succeded.
  Output was: Execution failed for task ':app:testDebugUnitTest'.
> There were failing tests. See the report at: file:///home/travis/build/connectbot/connectbot/app/build/reports/tests/debug/index.html
```
