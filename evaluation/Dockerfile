FROM ubuntu:14.04

##### install mono, from: https://stackoverflow.com/a/25165946

RUN sudo apt-get update

RUN sudo apt-get install -y wget

RUN sudo /bin/bash -l -c "wget http://download.mono-project.com/repo/xamarin.gpg"

RUN sudo apt-key add xamarin.gpg

RUN sudo echo "deb http://download.mono-project.com/repo/debian wheezy main" > /etc/apt/sources.list.d/mono-xamarin.list

RUN sudo apt-get update

RUN sudo apt-get install -y mono-complete

##### Intstall R

RUN apt-get install -y r-base

##### install Ruby, from: https://github.com/dockerfile/ruby/blob/master/Dockerfile

# basics
RUN apt-get install -y openssl

# install RVM, Ruby, and Bundler
RUN apt-get install -y curl

RUN gpg --keyserver hkp://pool.sks-keyservers.net --recv-keys 409B6B1796C275462A1703113804BB82D39DC0E3 7D2BAF1CF37B13E2069D6956105BD0E739499BDB

RUN \curl -L https://get.rvm.io | bash -s stable
RUN sudo /bin/bash -l -c "rvm requirements"
RUN sudo /bin/bash -l -c "rvm install 2.6.3"
RUN sudo /bin/bash -l -c "gem install bundler"

## collect relevant tools together
COPY tool tool
COPY pbe-extraction-buildlogs pbe-extraction-buildlogs
COPY r-extractions r-extractions
COPY evaluation evaluation

WORKDIR "/"

RUN find /r-extractions/. -exec sed -i -e 's|main_path <<- "/Users/Laci/Documents/Delft/master-thesis"|main_path <<- ""|g' {} \;
RUN find /evaluation/. -exec sed -i -e 's|main_path <<- "/Users/Laci/Documents/Delft/master-thesis"|main_path <<- ""|g' {} \;

RUN sudo /bin/bash -l -c "Rscript evaluation/install_packages.R"

WORKDIR "/pbe-extraction-buildlogs"

RUN sudo /bin/bash -l -c "msbuild /p:Configuration=Release"

WORKDIR "/evaluation"

RUN sudo /bin/bash -l -c "ls"
RUN sudo /bin/bash -l -c "pwd"

RUN sudo /bin/bash -l -c "ruby run-evaluation.rb"
RUN sudo /bin/bash -l -c "Rscript plot-prose.R"
