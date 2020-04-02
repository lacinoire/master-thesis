#!/bin/sh
# Remove carriage returns (keeping line feeds)
tr -d \\r |
# Start sentences on a new line
sed 's/\.  */.\n/g' |
# Fold (but don't join) remaining long lines
fmt -s
