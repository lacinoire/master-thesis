## Start from xenial
FROM rocker/r-apt:xenial

## Update and install rstan
RUN apt-get update && apt-get install -y --no-install-recommends r-cran-xml &&\
    apt-get install -y --no-install-recommends r-cran-svglite &&\
    apt-get install -y --no-install-recommends r-cran-stringdist &&\
    apt-get install -y --no-install-recommends r-cran-ggplot2 &&\
    apt-get install -y --no-install-recommends r-cran-dplyr &&\
    apt-get install -y --no-install-recommends r-cran-text2vec &&\
    apt-get install -y --no-install-recommends r-cran-stringi &&\
    apt-get install -y --no-install-recommends r-cran-stringr &&\
    apt-get install -y --no-install-recommends r-cran-purrr

COPY . r-extractions

## Make R the default
CMD ["bash"]