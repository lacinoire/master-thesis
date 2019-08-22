# Exploratory Tool to extract Bulidlog Information using Programming by Example

Bulid in this folder with:

``` shell
msbuild /v:m /p:Configuration=Debug
```

execute (on unix) with:

``` shell
mono pbe-extraction-buildlogs/bin/Debug/pbe-extraction-buildlogs.exe <args>
```

usage:

``` shell
mono pbe-extraction-buildlogs/bin/Debug/pbe-extraction-buildlogs.exe analyze -f <path for file to analyze> -p <program name>
```

execute without arguments for help text 🙂

Find the predefined examplesets in the [example set folder](../tool/example-sets/). The buildlogs used for the examples are inside the [samples folder](../tool/samples/).
