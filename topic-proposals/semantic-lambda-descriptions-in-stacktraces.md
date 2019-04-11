# Semantic Lambda Descriptions in Java Stacktraces

Master Thesis Topic Proposal

## Problem Description

Tracing references of lambda calls to source code is difficult for developers.

### Problem Source / Motivation

Java streams not widely adopted also because of debugging difficulties: Davood Mazinanian et al. *Understanding the use of lambda expressions in Java*

## Solution Sketch

+ Design a notion to semantically describe a lambda
+ Extend jdk so this new notion is used instead of the `lambda$main$3` identifier in a stacktrace
+ Evaluate whether this actually improves tracability for developers

### Existing work which might be useful for solution

+ Paper about generating natural language documentation for lambdas: Alqaimi, Anwar et al. *Automatically Generating Documentation for Lambda Expressions in Java*

## Discussion

### General

+ Might line numbers be enough when writing "good" code (each lambda gets a separate line)?
+ Sometimes line numbers link to the line of the "collect" call (this is the point that forces the lambdas defined earlier in the stream to be executed), not the line where the actual exception is thrown/next method is called *in code*

### Scope

#### pro Scope

+ area of improvement clearly defined
+ clear evaluation question

#### con Scope

+ Extending the jdk could be a lot of implementation effort

### Feasibility & Competence

#### pro Feasibility & Competence

+ single point of change in the jdk

#### con Feasibility & Competence

+ Can we usefully represent the in general complex semantics of a lambda short enough for a stacktrace?

### Research-Relevance

#### pro Research-Relevance

+ Describing the semantics of lambda expressions in a compact enough way for a stacktrace could be generalized to other languages
+ "Natural Language Description" until now only developed for lambdas containing one expression → maybe extend for multiple expressions

#### con Research-Relevance

+ "Natural Language Description" was already done. Will there be more contribution than shortening this existing description?

### Personal Preference

#### pro Personal Preference

#### con Personal Preference
