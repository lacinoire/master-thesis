# How to Analyze Build Logs - A Comparative Study of Chunk Retrieval Techniques

Welcome to our replication package! 😊

Here you'll find the implementations of the four chunk retrieval techniques we
compared:
- [program synthesis by example using Microsoft's PROSE library (PBE)](pbe-extraction-buildlogs)
- [common text similarity (CTS)](r-extractions)
- [keyword search (KWS)](r-extractions)
- [random line retrieval (RLR)](r-extractions)

If you want to execute them for specific examples, check out our [unification tool](tool)!

If you want to replicate our empirical study keep reading :)

In the [`tool`](tool) folder we keep a modified (adapted folder & xml structure) version of the [LogChunks data set](https://zenodo.org/record/3632351).
We provide Dockerfiles for the evaluation of each of the four techniques.
When executing them we bind-mount this folder so the results can be written out to `evaluation/results`.
The evaluation also contains the unified result files of our evaluation as well as the python notebooks we used or analyzing the data.

## Run Ealuation of PBE
build (from within this folder):
``` bash
docker image build -t pbe -f pbe-extraction-buildlogs/DockerfilePBE .
```

run (from within this folder):
``` bash
docker run --rm -it --mount type=bind,source=$(pwd),target=/master-thesis pbe
```

## Run Evaluation of CTS
build (from within this folder):
``` bash
docker image build -t cts -f r-extractions/DockerfileCTS .
```

run (from within this folder):
``` bash
docker run --rm -it --mount type=bind,source=$(pwd),target=/master-thesis cts
```

# TODO replace 'master-thesis' with better name for whole folder

## Run Evaluation of CTS
build (from within this folder):
``` bash
docker image build -t kws -f r-extractions/DockerfileKWS .
```

run (from within this folder):
``` bash
docker run --rm -it --mount type=bind,source=$(pwd),target=/master-thesis kws
```
## Run Evaluation of CTS
build (from within this folder):
``` bash
docker image build -t rlr -f r-extractions/DockerfileRLR .
```

run (from within this folder):
``` bash
docker run --rm -it --mount type=bind,source=$(pwd),target=/master-thesis rlr
```

## Runtimes
We executed our evaluation on a server with these specs: Intel(R) Xeon(R) CPU E5-2690 v4 @ 2.60GHz.
The rough runtimes were:
PBE: 19 h
CTS: 15 min
KWS: 25 min
RLR: 5 min

