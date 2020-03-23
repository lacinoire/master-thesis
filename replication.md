# How to Analyze Build Logs - A Comparative Study of Chunk Retrieval Techniques

Welcome to our replication package! 😊

Here you'll find the implementations of the four chunk retrieval techniques we
compared:
- [program synthesis by example using Microsoft's PROSE library (PBE)](pbe-extraction-buildlogs)
- [common text similarity (CTS)](r-extractions)
- [keyword search (KWS)](r-extractions)
- [random line retrieval (RLR)](r-extractions)

If you want to execute them for specific examples only, check out our [unification tool](tool)!

If you want to replicate our empirical study keep reading :)

In the [`tool`](tool) folder we keep a modified (adapted folder & xml structure) version of the [LogChunks data set](https://zenodo.org/record/3632351).
We provide Docker files that have the unification tool configured for the evaluation of each of the four techniques.
When executing them we bind-mount this folder so the results are be written out to `evaluation/results`.

## Run Evaluation of PBE
build (from within this folder):
``` bash
docker image build --network host -t pbe -f pbe-extraction-buildlogs/DockerfilePBE .
```

run (from within this folder):
``` bash
docker run --rm -it --mount type=bind,source=$(pwd),target=/chunk-retrieval-replication pbe
```

## Run Evaluation of CTS
build (from within this folder):
``` bash
docker image build --network host -t cts -f r-extractions/DockerfileCTS .
```

Should an error occurr ("")

run (from within this folder):
``` bash
docker run --rm -it --mount type=bind,source=$(pwd),target=/chunk-retrieval-replication cts
```

## Run Evaluation of KWS
build (from within this folder):
``` bash
docker image build --network host -t kws -f r-extractions/DockerfileKWS .
```

run (from within this folder):
``` bash
docker run --rm -it --mount type=bind,source=$(pwd),target=/chunk-retrieval-replication kws
```
## Run Evaluation of RLR
build (from within this folder):
``` bash
docker image build --network host -t rlr -f r-extractions/DockerfileRLR .
```

run (from within this folder):
``` bash
docker run --rm -it --mount type=bind,source=$(pwd),target=/chunk-retrieval-replication rlr
```

# TODO 

## Runtimes
We executed our evaluation on a server with these specs: Intel(R) Xeon(R) CPU E5-2690 v4 @ 2.60GHz.
The rough runtimes were:
PBE: 19 h
CTS: 15 min
KWS: 25 min
RLR: 5 min

## Python Notebooks

The evaluation folder also contains the unified result files of our evaluation as well as the three python notebooks we used or analyzing the data in the results sub-folder.

