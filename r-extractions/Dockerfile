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

COPY . r-extractions

RUN find /r-extractions/. -type f -exec sed -i -e 's|main_path <<- "/Users/Laci/Documents/Delft/master-thesis"|main_path <<- ""|g' {} \; &&\
    /bin/bash -l -c "Rscript r-extractions/install_packages.R"

## Make R the default
CMD ["bash"]