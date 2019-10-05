FROM mono:latest

COPY pbe-extraction-buildlogs pbe-extraction-buildlogs
COPY evaluation evaluation
COPY tool tool

WORKDIR "/pbe-extraction-buildlogs"

RUN nuget restore
RUN msbuild pbe-extraction-buildlogs/pbe-extraction-buildlogs.csproj /p:Configuration=Release

RUN apt-get update &&\
    apt-get install vim &&\
    apt-get install -y ruby ruby-dev ruby-bundler

RUN find /evaluation/. -type f -exec sed -i -e 's|<technique>|pbe|g' {} \; &&\
    find /pbe-extraction-buildlogs/. -type f -exec sed -i -e 's|RESULT_DIRECTORY = ROOT_DIRECTORY + "evaluation/results/pbe/";|RESULT_DIRECTORY = ROOT_DIRECTORY + "master-thesis/evaluation/results/pbe/";|g' {} \;

WORKDIR "/evaluation"

CMD ["bash"]
