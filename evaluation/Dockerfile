FROM ubuntu:18.10
ENV DEBIAN_FRONTEND noninteractive

##### install fish

RUN apt-get -qq update --quiet && \
    apt-get -qq install --quiet --yes software-properties-common && \
    add-apt-repository --yes ppa:fish-shell/release-3 && \
    apt-get -qq install --quiet --yes fish



##### install mono, from: https://stackoverflow.com/a/25165946

RUN apt-get -qq update &&\
    apt-get -qq install -y wget

RUN /bin/bash -l -c "wget http://download.mono-project.com/repo/xamarin.gpg" &&\
    apt-key add xamarin.gpg

RUN echo "deb http://download.mono-project.com/repo/debian wheezy main" > /etc/apt/sources.list.d/mono-xamarin.list &&\
    apt-get -qq update &&\
    apt-get -qq install -y mono-complete &&\ 
##### Intstall R
    apt-get -qq -y install --no-install-recommends --no-install-suggests \
        ca-certificates software-properties-common gnupg2 gnupg1 &&\
    apt-key adv --keyserver keyserver.ubuntu.com --recv-keys E298A3A825C0D65DFD57CBB651716619E084DAB9 &&\
    add-apt-repository 'deb https://cloud.r-project.org/bin/linux/ubuntu bionic-cran35/' &&\
    apt-get -qq install -y r-base

## Update and install rstan
RUN apt-get -qq update && apt-get -qq install -y --no-install-recommends r-cran-xml

RUN apt-get -qq install -y --no-install-recommends r-cran-stringdist &&\
    apt-get -qq install -y --no-install-recommends r-cran-ggplot2 &&\
    apt-get -qq install -y --no-install-recommends r-cran-dplyr &&\
    apt-get -qq install -y --no-install-recommends r-cran-text2vec &&\
    apt-get -qq install -y --no-install-recommends r-cran-stringi &&\
    apt-get -qq install -y --no-install-recommends r-cran-stringr &&\
    apt-get -qq install -y --no-install-recommends r-cran-purrr

RUN apt-get -qq install -y --no-install-recommends r-cran-svglite &&\
##### install Ruby, from: https://github.com/dockerfile/ruby/blob/master/Dockerfile
# basics
    apt-get -qq install -y openssl &&\
# install RVM, Ruby, and Bundler
    apt-get -qq install -y curl &&\
    gpg --keyserver hkp://pool.sks-keyservers.net --recv-keys 409B6B1796C275462A1703113804BB82D39DC0E3 7D2BAF1CF37B13E2069D6956105BD0E739499BDB &&\
    \curl -L https://get.rvm.io | bash -s stable &&\
    /bin/bash -l -c "rvm requirements" &&\
    /bin/bash -l -c "rvm install 2.6.3" &&\
    /bin/bash -l -c "gem install bundler"

## collect relevant tools together
COPY tool tool
COPY pbe-extraction-buildlogs pbe-extraction-buildlogs
COPY r-extractions r-extractions
COPY evaluation evaluation

WORKDIR "/"

RUN find /r-extractions/. -type f -exec sed -i -e 's|main_path <<- "/Users/Laci/Documents/Delft/master-thesis"|main_path <<- ""|g' {} \; &&\
    find /evaluation/. -type f -exec sed -i -e 's|main_path <<- "/Users/Laci/Documents/Delft/master-thesis"|main_path <<- ""|g' {} \; &&\
    /bin/bash -l -c "Rscript evaluation/install_packages.R"

WORKDIR "/pbe-extraction-buildlogs"

RUN /bin/bash -l -c "msbuild /p:Configuration=Release"

# WORKDIR "/evaluation"

##### configure fish as shell
SHELL ["fish", "--command"]

RUN chsh -s /usr/bin/fish

ENV SHELL /usr/bin/fish
ENV LANG=C.UTF-8 LANGUAGE=C.UTF-8 LC_ALL=C.UTF-8
ENTRYPOINT [ "fish" ]