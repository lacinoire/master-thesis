# Example sets to train the chunk retrieval techniques in our tool

xml-structure:
``` xml
<?xml version="1.0" encoding="utf-8"?>
<AnalysisProgramOfRegionAnalysisSessionString xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <SaveName>... path to this file relavtive to the example-sets folder ...</SaveName>
  <LearningData>
    <InputPaths>
      <string>... path to the build log files relative to the samples folder ... ... only used for pbe's 'also use inputs' feature ...</string>
      <string>JavaScript/airbnb@javascript/failed/563286141.log</string>
      ...
    </InputPaths>
    <Examples>
      <ExampleDataOfString> ... this containes one in/output example, see example below ...
        <InputPath>... path to the build log files relative to the samples folder ...</InputPath>
        <Keywords>... comma separated keywords the technique 'keyword'/'KWS' will search for ...</Keywords>
        <Category>... integer specifying in which structural category this example is ...</Category>
        <Output>
        ... chunk the retrieval should target for this input ...
        </Output>
      <ExampleDataOfString>
      <ExampleDataOfString> ...this containes one in/output example
        <InputPath>JavaScript/airbnb@javascript/failed/563286141.log</InputPath>
        <Keywords>notOk, Error, </Keywords>
        <Category>0</Category>
        <Output>operator: notOk
    expected: false
    actual:   1
    at: Test.&lt;anonymous> (/home/travis/build/airbnb/javascript/packages/eslint-config-airbnb/test/test-react-order.js:57:7)
    stack: |-
      Error: no errors
          at Test.assert [as _assert] (/home/travis/build/airbnb/javascript/packages/eslint-config-airbnb/node_modules/tape/lib/test.js:225:54)
          at Test.bound [as _assert] (/home/travis/build/airbnb/javascript/packages/eslint-config-airbnb/node_modules/tape/lib/test.js:77:32)
          at Test.notOK (/home/travis/build/airbnb/javascript/packages/eslint-config-airbnb/node_modules/tape/lib/test.js:357:10)
          at Test.bound (/home/travis/build/airbnb/javascript/packages/eslint-config-airbnb/node_modules/tape/lib/test.js:77:32)
          at Test.&lt;anonymous> (/home/travis/build/airbnb/javascript/packages/eslint-config-airbnb/test/test-react-order.js:57:7)
          at Test.bound [as _cb] (/home/travis/build/airbnb/javascript/packages/eslint-config-airbnb/node_modules/tape/lib/test.js:77:32)
          at Test.run (/home/travis/build/airbnb/javascript/packages/eslint-config-airbnb/node_modules/tape/lib/test.js:93:10)
          at Test.bound [as run] (/home/travis/build/airbnb/javascript/packages/eslint-config-airbnb/node_modules/tape/lib/test.js:77:32)
          at Test._end (/home/travis/build/airbnb/javascript/packages/eslint-config-airbnb/node_modules/tape/lib/test.js:162:11)
          at Test.bound [as _end] (/home/travis/build/airbnb/javascript/packages/eslint-config-airbnb/node_modules/tape/lib/test.js:77:32)</Output>
      <ExampleDataOfString>
      ...
    </Examples>
  </LearningData>
  <LogKind> ... no longer used, you can just copy this ...
    <Language>java</Language>
    <BuildTool>android</BuildTool>
  </LogKind>
  <Target>BuildFailureReason</Target>
</AnalysisProgramOfRegionAnalysisSessionString>
```
