# Intermediate Language with OO and Functional Features

Master Thesis Topic Proposal  
*status:* rough idea, feasability & innovativeness not clear

## Problem Description

Design an Intermediate Language (similar to bytecode or IL) that provides both oo and functional features.

### Problem Source / Motivation

Java Lambda Instances are currently implemented as Objects of Functional Interfaces, because the language for the JVM is OO. This leads to "strange" restrictions like not beeing able to use `break` or `continue` in a functional `forEach`-Loop. It also leads to "unexpected" bytecode structures and complicated internal structures which simulate functional capabilities & in turn pollute stack traces with library function calls.

## Solution Sketch

+ Design Language (Abstract & Concrete Syntax)
+ Provide example Compiler for e.g. restricted Java (+ primarily functional language might make it more interesting)
+ Evaluation: no study, technical: how many language features can we accurately (no building workaround libraries) represent?

### Existing work which might be useful for solution

## Discussion

### Scope

#### pro Scope

#### con Scope

+ Incorporating all features of current state of the Art languages will not be possible → restrict to a subset of important ones
+ Where is the software engineering aspect here?

### Feasibility & Competence

#### pro Feasibility & Competence

#### con Feasibility & Competence

+ Do we (together) have enough experience on intermediate languages & compilers?

### Research-Relevance

#### pro Research-Relevance

#### con Research-Relevance

+ For LISP, combining functional & OO: *CLOS: integrating object-oriented and functional programming* Richard P. Gabriel et al.
+ *C++ lambda expressions and closures* Jaakko Järvi, John Freeman

### Personal Preference

#### pro Personal Preference

+ Language Design is fun!

#### con Personal Preference
