# Are Java streams really harder to debug than traditional code?

Master Thesis Topic Proposal  
*status:* quite clear problem & solution, preference to do this & research contribution to be assessed

## Problem Description

It is a widespread belief that Java Streams are hard to debug. However this was not yet shown by research (**TODO** really? check for existing studies).

### Problem Source / Motivation

Well-written stream/lambda code, which means each stream operation & each lambda gets a separate source code line, might provide enough tracability between stacktraces & code.

## Solution Sketch

+ Online study for quantitative evaluation
  + Build site that shows an exception stacktrace next to a code explorer
  + Task: Find the line which is responsible for the failure
  + Variation: lambda/stream code vs. same task with iterative concepts
  + Measure: Time, Interaction with various elements on the site
+ Offline study for more in-depth & qualitative evaluation
  + maybe incorporate bio sensors (eye tracker)?  
  → more detailed insight on *why* tracing takes longer  
  → results here might be generalizable, "what informations do developers use while debugging" (this was already done in some scenarios: *Eye gaze and mouse cursor relationship in a debugging task* M Chen, V Lim; *Temporal eye-tracking data: evolution of debugging strategies with multiple representations* R Bednarik, M Tukiainen)

### Existing work which might be useful for solution

## Discussion

### Scope

#### pro Scope

+ study count & depth could be easily ajusted

#### con Scope

### Feasibility & Competence

#### pro Feasibility & Competence

+ a lot of experience with empirical studies in the group

#### con Feasibility & Competence

### Research-Relevance

#### pro Research-Relevance

+ challenging a wide-spread belief

#### con Research-Relevance

+ is the research question broad enough?
+ what distinguishes our approach from already conducted studies?  
most about debugging in general, but they also talk about traceability between error message & code

### Personal Preference

#### pro Personal Preference

#### con Personal Preference

+ "just a study" might be a bit boring
