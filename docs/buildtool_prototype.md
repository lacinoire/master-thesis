# What "output tool" do we have currently and what do we want in the end

#### Goal: have a _research prototype_

- enable others to reproduce our experiments exaclty
- inspire replication studies and future work through: useable datasets and clear usage documentation

## What do we have

- given an example-set file (see an example below!) we can trigger a prose learning session trough the command line 
- same with IR now
- also both: we can trigger an "evaluation" of both methods  
  evaluation here means:  
  the technique will be triggered in steps with an increasing number of examples  
  a program will be learned and then applied to a test build log (currently the next one in the exampleset)  
  the output is saved & used for calculating accuracy / correctness
  results are collected and (can later be) plotted

## What will we have (in a few weeks when decided upon implementation is done)

- single file analysis and evaluation with 
  - keyword search and 
  - random baseline and
  - manual regex
- combined triggering of the different methods for evaluation
- automatically generating + saving plots & result tables (only works partially)

## What we (currently) do not plan to do

- industry ready tool to directly integrate into e.g. travis ci
- UI for defining examples
- a functionality where you can put in any buildlog and it extracts a datapoint like "the failing test".  
  A user still always has to specify a certain set of examples to use and also provide this set of examples if he is not using one we already defined.  
  If he wants to use one of our extractions for his project he will likely have to give examples himself.
- a layer _on top_ of the extraction programs that distinguishes by kind (= language/build tool) and selects an appropriate extraction program

## Usage of our research prototype workflow

1. Starting with a collection of build logs which we want to analyze. This means we have selected an an Information point which we want to extract out of a log from this collection.
2. An example set is needed for the analysis.  
   either 
   - the researcher/user takes one that we already defined, because it fits his logs  
 or
   - they create one themselves by writing a document like the following
  
``` xml
<?xml version="1.0" encoding="utf-8"?>
<AnalysisProgramOfRegionAnalysisSessionString xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <SaveName>android-failure</SaveName>
  <LearningData>
    <InputPaths>
      <string>connectbot@connectbot/3.log</string>
      <string>connectbot@connectbot/5.log</string>
      ...
    </InputPaths>
    <Examples>
      <ExampleDataOfString>
        <InputPath>connectbot@connectbot/3.log</InputPath>
        <Output>Execution failed for task ':app:compileDebugNdk'.
> NDK not configured.
  Download the NDK from http://developer.android.com/tools/sdk/ndk/.Then add ndk.dir=path/to/ndk in local.properties.
  (On Windows, make sure you escape backslashes, e.g. C:\\ndk rather than C:\ndk)</Output>
      </ExampleDataOfString>
      <ExampleDataOfString>
        <InputPath>
        ...
```

3. Run the anlaysis: See our new `tool` folder for the consolidated interface or the `pbe-extraction-buildlogs/readme.md` / the IR implementation in the folder `evaluation` for how to run the analysis.  
   for the consolidated tool:  

``` shell
>  ruby run-extraction.rb --help
Usage: ruby run-extraction.rb -a analyze -t <technique> -e <example_set> -p <path_to_file_to_analyze>
       ruby run-extraction.rb -a evaluate -t <technique> -e <example_set> -s <selection_technique> -l <step_count_for_learning> -c <test_count>

Specific options:
    -a, --action ACTION              Either run an extraction for a example set ('analyze') or run the whole evaluation of it ('evaluate')
    -t, --technique TECHNIQUE        The technique used for creating the extraction program (pbe, ir, keyword, random)
    -e, --example-set EXAMPLE_SET    The filename of the example set to use
    -p, --path PATH                  The path to the file to be analyzed
    -s, --selection SELECTION        The example sequence selection technique to use for evaluation (chronological, random, manual (= like defined in file))
    -l, --learning-step-count COUNT  How many steps with increasing example set size to do during evaluation
    -c, --test-count COUNT           How many test files to evaluate the generated program in each learning step of the evaluation

Common options:
    -h, --help                       Show this message

```

output will then be the extracted part of the buildlog. 😃

4. optional: run the whole evaluation: generate data tables & plots as well