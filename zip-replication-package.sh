#! /bin/bash

mkdir chunk-retrieval-replication

cp -r evaluation chunk-retrieval-replication/evaluation
cp -r pbe-extraction-buildlogs chunk-retrieval-replication/pbe-extraction-buildlogs
cp -r r-extractions chunk-retrieval-replication/r-extractions
cp -r tool chunk-retrieval-replication/tool
cp replication.md chunk-retrieval-replication/readme.md
cp .gitignore chunk-retrieval-replication/.gitignore

zip -r chunk-retrieval-replication.zip chunk-retrieval-replication

rm -rf chunk-retrieval-replication
