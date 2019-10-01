# Master Document of Caro's Master Thesis Write-Up
Here collection and planning of what / how I want to write paper and master thesis.  
Adjacent documents: Workflowy "notes" section of random things I want to hold somewhere & Workflowy "open questions" section & Workflowy "todo" section

# What to write in the paper

## ---------- INTRODUCTION / BACKGROUND / THEORETICAL STUFF ----------

## motivation
- buildlogs huge valuable information source for developers and **researchers**
- but only if they can extract the right information from the verbose / many lines
- ancedotally mention different techniques and already compare here? make sure that it sounds like there is actual value in my work then. also as we moved on to comparing a general "hard to choose" story might be better than saying one is for a specific case better then the other (in the introduction)

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
- available information in _build logs_ vs. information extraction techniques (maybe outside of build logs)
- which how much of that will we come up in our research? story wise I mean

## focus down to the three different approaches we compare
- 3? _really do not do more_    ; though: do we have more? is random a proper one?
- can we somehow motivate why these three?

## describe our three approaches & the background behind them
- represent in model we chose for approaches
- for all: input / output side conditions
- flow pictures!!

### prose pbe
- start cause this is the first one we looked at?
- a bit of background of the library
- paper: short short how it works, master thesis: long how it works

### IR text similarity
- our approach
- motivate "common" ir approach chosen

### keyword search
- ad-hoc technique
- our approach to that with keywords searched for but also context extracted

## RESEARCH QUESTIONS

- RQ1: Is Programming by Example suited to extract information from CI build logs?
- RQ2: What criteria influence the suitability of an information extraction technique for CI build logs?
- RQ3: When are text similarity or keyword search better suited for information extraction from CI build logs?

## ---------- IMPLEMENTATION ----------

- hmm how much is to say here? especially for the paper...
- master thesis: go into detail here! show aaaall the work done

## our (unification) tool
- what can it do?
- how can others use it?
- (how can others extend it? thesis?)

## ---------- COMPARISON / "EVALUATION" / STUD(Y|IES) ----------

## our data set
- how we collected logs (take from existing paper draft)
- what data points we have & motivate what we need them for
- how others can reuse it, (how others could add to it?)

## validation of our data set data points
- inter-rater reliability thing
- **Mails to developers study**

## evaluation
- TODO look at IMRA or so sturcture that Moritz proposed for the last draft, can we use that?
- evaluations we ran then: something to say in general? we do run one big evaluation isn't it?

### motivate all the decisions we made!
- why not k-fold? (chronological in real-world use, though can we argue that if we do random?)
- why so little examples? examples only valid for one repository, user would not be willing to give more, (how could we generalize and let examples span multiple repos?)
- why chronological? (if we decide to do that) cause closer to real world usage

### how we interpret results
- accuracy of findings
- proximity

### results
- interesting stuff to look at here
- incorporate interpretation of them directly?

### discussion
- all the results together & in relation

## ANSWER RESEARCH QUESTIONS

- RQ1: Is Programming by Example suited to extract information from CI build logs?  
  break down into: regex suited & pbe specific & prose specific
- RQ2: What criteria influence the suitability of an information extraction technique for CI build logs?  
  group: criteria about logs & input avaliable for technique configuration
- RQ3: When are text similarity or keyword search better suited for information extraction from CI build logs?

## ---------- RELATED WORK ----------
- from existing paper draft
- something to add?
- traditional log analysis: logpai/loghub
- papers about keyword search?
- prose theoretical papers (Moritz wanted that, does it fit into the paper with the current story? thesis: sure)

## ---------- FUTURE WORK ----------
- adding more techniques, evaluating them in the same way
- other works with data set
- refine / improve / adjust techniques (like pbe) with results / data set evaluation, → meta-parameter optimization?

## ---------- CONCLUSION ----------
- nothing special, wrap up story

## glossary?
- build log
- information (extraction) technique
- keyword search / IR similarity / pbe
- (I/O) example
- exampleset

## CONTRIBUTIONS
- data set /w logs, labeled extractions (one interesting information), keywords & categories
- extraction (unification) tool
- meta modell of? data that is extractable? information extraction techniques & their configuration / data extraction tasks
