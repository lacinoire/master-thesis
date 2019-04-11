# Extending Debuggers with Operations for Lambads & Streams

Master Thesis Topic Proposal

## Problem Description

The IntelliJ Debugger can not step into the second & following lambdas of this stream expression: `this.classes.parallelStream().filter(f -> f.contains("ArrayList")).forEach(f -> f.chars().forEach(i -> i++));`

### Problem Source / Motivation

## Solution Sketch

**TODO** analyze the missing operations in the IntelliJ Debugger

+ Analyze exsting debugger interfaces and their ability to represent stepping operations within (nested) streams / lambdas
+ Design additional actions
+ Implement for example debugger
+ Evaluation: Compare old & new version with devs

### Existing work which might be useful for solution

## Discussion

### Scope

#### pro Scope

#### con Scope

### Feasibility

#### pro Feasibility

#### con Feasibility

### Research-Relevance

#### pro Research-Relevance

+ additional debugger actions could be generlized to other languages → evaluate applicability for other languages

#### con Research-Relevance

### Personal Competence & Preference

#### pro Personal Competence & Preference

#### con Personal Competence & Preference
