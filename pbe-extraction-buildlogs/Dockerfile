FROM mono:latest

RUN mono --version
RUN msbuild pbe-extraction-buildlogs.sln

CMD ["mono pbe-extraction-buildlogs/bin/Release/pbe-extraction-buildlogs.exe"]