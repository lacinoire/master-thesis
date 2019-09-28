## Start from xenial
FROM rocker/r-apt:xenial

## Update and install rstan
RUN apt-get update && apt-get install -qq -y --no-install-recommends r-cran-xml &&\
    apt-get install -qq -y --no-install-recommends r-cran-svglite &&\
    apt-get install -qq -y --no-install-recommends r-cran-stringdist &&\
    apt-get install -qq -y --no-install-recommends r-cran-ggplot2 &&\
    apt-get install -qq -y --no-install-recommends r-cran-dplyr &&\
    apt-get install -qq -y --no-install-recommends r-cran-text2vec &&\
    apt-get install -qq -y --no-install-recommends r-cran-stringi &&\
    apt-get install -qq -y --no-install-recommends r-cran-stringr &&\
    apt-get install -qq -y --no-install-recommends r-cran-purrr

RUN apt-get -qq install -y --no-install-recommends r-cran-rcpp

COPY r-extractions r-extractions
COPY evaluation evaluation
COPY tool tool

RUN find /r-extractions/. -type f -exec sed -i -e 's|main_path <<- "/Users/Laci/Documents/Delft/master-thesis"|main_path <<- ""|g' {} \; &&\
    find /evaluation/. -type f -exec sed -i -e 's|main_path <<- "/Users/Laci/Documents/Delft/master-thesis"|main_path <<- ""|g' {} \; &&\
    find /evaluation/. -type f -exec sed -i -e 's|setwd(paste0(main_path, "/evaluation/results/", technique))|setwd(paste0(main_path, "/master-thesis/evaluation/results/", technique))|g' {} \; &&\
    /bin/bash -l -c "Rscript r-extractions/install_packages.R"

RUN find /evaluation/. -type f -exec sed -i -e 's|<technique>|ir|g' {} \;

RUN apt-get install -y ruby ruby-dev ruby-bundler

WORKDIR "/evaluation"

CMD ["bash"]