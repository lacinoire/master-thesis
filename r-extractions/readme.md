# Various Scripts to extract Information from Build logs written in R

In this folder you will find various R scripts used to extract lines from build log files.
Check out our [unification tool](../tool) for one CLI to call all these extractions 🙃

All paths of example sets are relative to [`tool/example-sets`](../tool/example-sets), all paths of build log files / samples are relative to [`tool/samples`](../tool/samples).

## [Information Retrieval](information-retrieval.R)

Usage:

```console
Rscript information-retrieval.R analyze --program <example set name> --file <file to analyze> [--verbose]
```
```console
Rscript information-retrieval.R evaluate --program <example set name> --selection <sample selection technique: manual, chronological, random> --test-count <number of tests to be run with learned program>
--learning-step-count <max number of samples to learn with in the evaluation> [--verbose]
```

## [Keyword search](keyword-search.R)

Usage:

```console
Rscript keyword-search.R analyze --file <file to analyze> --keywords <space separated keywords to filter by>
```
```console
Rscript keyword-search.R evaluate --program <example set name> --selection <sample selection technique: manual, chronological, random> --test-count <number of tests to be run with learned program>
--learning-step-count <max number of samples to learn with in the evaluation> [--verbose]
```

## [Manual Regex](manual-regex.R)

Usage:

```console
Rscript manual-regex.R analyze --file <file to analyze> --regex "<regex to select extraction>"
```
```console
Rscript manual-regex.R evaluate // not implemented
```

## [Random Selection](random-selection.R)

Usage:

```console
Rscript random-selection.R analyze --program <example set name (used to calculate average number of lines for a desired extraction)> --file <file to analyze> [--verbose]
```
```console
Rscript random-selection.R evaluate --program <example set name> --selection <sample selection technique: manual, chronological, random> --test-count <number of tests to be run with learned program>
--learning-step-count <max number of samples to learn with in the evaluation> [--verbose]
```
