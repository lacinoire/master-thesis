FROM mono:latest

COPY pbe-extraction-buildlogs pbe-extraction-buildlogs
COPY evaluation evaluation
COPY tool tool

WORKDIR "/pbe-extraction-buildlogs"

RUN nuget restore
RUN msbuild pbe-extraction-buildlogs/pbe-extraction-buildlogs.csproj /p:Configuration=Release

RUN apt-get update && \
    apt-get install -y ruby ruby-dev ruby-bundler

RUN find /evaluation/. -type f -exec sed -i -e 's|<technique>|pbe|g' {} \;

WORKDIR "/evaluation"

CMD ["bash"]
