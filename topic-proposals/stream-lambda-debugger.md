# Extending Debuggers with Operations for Lambads & Streams

Master Thesis Topic Proposal  
*status:* idea, neccessity unclear, solution to be defined further

## Problem Description

The IntelliJ Debugger can not step into the nested lambdas of this stream expression: `this.classes.parallelStream().filter(f -> f.contains("ArrayList")).forEach(f -> f.chars().forEach(i -> i++));`

### Problem Source / Motivation

## Solution Sketch

analyze the missing operations in the IntelliJ Debugger

+ Analyze exsting debugger interfaces and their ability to represent stepping operations within (nested) streams / lambdas
+ Design additional actions
+ Implement for example debugger
+ Evaluation: Compare old & new version with devs

### Existing work which might be useful for solution

## Discussion

Stepping into it is working for multiline lambdas:

```java
stringList.stream().filter(f -> f.contains("Hello")).forEach(f -> f.chars().forEach(i -> {
  i = i + 1;
  methodToThrowRuntimeException();
}));
```

+ repeatedly using "step into" always goes to the next lambda for the above example
+ "force step into" also goes into internal java lambda implementation

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
