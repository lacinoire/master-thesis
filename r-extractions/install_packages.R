r = getOption("repos")
r["CRAN"] = "http://cran.us.r-project.org"
options(repos = r)

install.packages("optigrab", dependencies=TRUE)
install.packages("wordcloud", dependencies=TRUE)
