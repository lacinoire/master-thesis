r = getOption("repos")
r["CRAN"] = "http://cran.us.r-project.org"
options(repos = r)

install.packages("optigrab", dependencies=TRUE)
install.packages("NLP", dependencies=TRUE)
install.packages("XML")
