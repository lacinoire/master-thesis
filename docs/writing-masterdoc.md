# Master Document of Caro's Master Thesis Write-Up
Here collection and planning of what / how I want to write paper and master thesis.  
Adjacent documents: Workflowy "notes" section of random things I want to hold somewhere & Workflowy "open questions" section

# What to write in the paper


## motivation
- buildlogs huge valuable information source for developers and **researchers**
- but only if they can extract the right information from the verbose / many lines

## explain common use cases of when devs or researchers would extract information from there
- NOT only the build failure reason (pack that into the middle somewhere)
- predictive CI (maybe slightly look into that further?)
- reference other papers / tools

## differentiate from "common **log** analysis"
- logs quite structured, lines = events based, one line kind of consistent structure with timestamp
- buildlogs while kind of structured not predicatble, different tools with potentially highly different output / different granularity then lines
- even with consistent tooling in Travis CI somethimes different formatting (random new lines, ansi coloring vs. no coloring)
- → what is applicable from their techniques?

## characterize build logs
- semi structuredness (what specifically does that mean?)
- warying sturcture
- how do we restrict ourselves in terms of types of build logs we look at? how for our research in general how specifically for our evaluation? (data/anectodal evideance for why limited view for evaluation is still fitting?)

## we want to do information extraction
- extract (one) specific information from a log at a time

### differentiate to "boil down to relevant information" approaches
- like diffing with clean log → how would we express diffing within our model?
- summariziation → we just do not do that though that might be valid in our topic

### characterize all the different approaches
- → meta-model??
- avaliable information in _build logs_ vs. information extraction techniques (maybe outside of build logs)




## glossary?
- build log
- keyword search / IR similarity / pbe
