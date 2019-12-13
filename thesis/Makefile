# Determine this makefile's path.
# Be sure to place this BEFORE `include` directives, if any.
THIS_FILE := $(lastword $(MAKEFILE_LIST))

.PHONY: FORCE_MAKE

all: main.pdf

.ONESHELL:
%.pdf: %.tex FORCE_MAKE
	#@$(MAKE) -f $(THIS_FILE) inputs
	latexmk -pdf -pdflatex="pdflatex" -cd -use-make -silent $<
# For a speed up with standalone tikz-pictures replace the above line with:
# 	latexmk -pdf -pdflatex="pdflatex -shell-escape" -use-make -silent $<

help:
	@ echo "Please chose one of the following make targets"
	@ echo "  all      : use LaTeX to build the main.pdf (default)"
	@ echo "  clean    : remove all files that are ignored by git"
	@ echo "  spell    : check the spelling inside your .tex files"
	@ echo "  submit   : build an archive for submission of the thesis"
.PHONY: help

clean:
	@ git clean -X --force --quiet
.PHONY: clean

spell:
	hunspell -d en_US -p dictionary.txt mini/*.tex txt/*.tex
.PHONY: spell

submit: main.pdf
	@ git archive --format=zip -9 HEAD -o thesis.zip
	@ zip -qu thesis.zip $<
	@ echo " => thesis.zip was successfully created"
.PHONY: submit

inputs: $(wildcard *.tex)
	ls txt/*.tex | awk '{printf "\\subfile{\\myrootdir/%s}\n", $$1}' > inputs.tex
.PHONY: inputs
