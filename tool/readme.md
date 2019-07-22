# Our research prototype for you! To try all our analyses yourself :)

This folder should contain all the necessary out & input for you to try out our build log information extraction tool.

  **WORK IN PROGRESS** the tool does not yet do what is promised here 😉

## Input

- Some [sample buildlogs](samples) for the extraction.  
  If you want to run analyses on your own logs please add them accordingly.
- Predefined [example sets](example-sets) you can use for learning.  
  Each contain input paths and in/output examples for extraction of one meta-model information object from a certain kind of build log.  
  For example: [`android-failure-with-dependencies`](example-sets/android-failure-with-dependencies.xml) extract the meta-model information `BuildFailureReason` from the kind of logs created from a `java` build log building for/with `android`

## Output

- The [results folder](results) containing all the data tables and plots generated when running the evaluation for the various extraction techniques

## Usage

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
    -v, --verbose                    Print additional interesting output apart from only the extraction output

Common options:
    -h, --help                       Show this message
```

## Working Examples

### Travis Worker Short

#### IR

``` shell
> ruby run-extraction.rb -a analyze -t ir -e travis-worker-short -p facebookgo@rocks-strata/166107245.log
```

Output:
``` txt
Using worker: worker-linux-docker-273f60df.prod.travis-ci.org:travis-linux-11
Target: x86_64-unknown-linux-gnu
GOHOSTOS="linux"
GOOS="linux"
```

#### Programming by Example

``` shell
> ruby run-extraction.rb -a analyze -t pbe -e travis-worker-short -p facebookgo@rocks-strata/166107245.log
```

Output:
``` txt
worker-linux-docker-273f60df.prod.travis-ci.org:travis-linux-11
```
