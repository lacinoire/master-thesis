# Exploratory Tool to extract Bulidlog Information using Programming by Example

In the [tool folder](../tool) you'll find our unification tool which can call this chunk retrieval technique and others & provides a cleaner documented interface 😊

Install mono: [https://www.mono-project.com/download/stable/]
(includes msbuild & nuget)

Before first build, add all required packages: 
``` shell
nuget restore
```
This should yield many lines of output reporting on adding packages.

Bulid in this folder with:

``` shell
msbuild /v:m /p:Configuration=Debug
```
This should yield few lines of output, ending with a report on the created `pbe-extraction-buildlogs.exe` file.

execute (on unix) with:

``` shell
mono pbe-extraction-buildlogs/bin/Debug/pbe-extraction-buildlogs.exe <args>
```

usage:

``` shell
mono pbe-extraction-buildlogs/bin/Debug/pbe-extraction-buildlogs.exe analyze -f <path for file to analyze> -p <program>
```
`program` stands for the name/path of the example set you wish to use 🐳

Find the predefined examplesets in the [example set folder](../tool/example-sets/).
The buildlogs used for the examples are inside the [samples folder](../tool/samples/).

## Usage
```
available verbs:
  analyze        Analyze the object at the given path.

  evaluate       Evaluate the learning of a given exampleset.

  interaction    Launch the original console text interaction

  help           Display more information on a specific command.

  version        Display version information.

all verbs:

  --help           Display this help screen.

  --version        Display version information.


analyze verb:

  -f, --file       Path of the file or folder to be analyzed

  -v, --verbose    Output detailed information and intermediate results instead of just the extraction result

  -p, --program    The program to run.


evaluate verb:

  -s, --selection              How examples for iterated learning should be seleced. Either 'random',  'chronological' or 'sequence' (taking the sequence in the example set configuration).

  -i, --include-inputs         Include all avaliable input paths as inputs in the learning process. Default: only files from examples are considered as possible inputs.

  -t, --test-count             On how many following examples the learned programs should be evaluated.

  -l, --learning-step-count    How many examples should maximally be used for learning during the evaluation.

  -p, --program                The program to run.
```
