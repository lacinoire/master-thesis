# run in a "<travis-status>" folder of the collected samples
# to generate a respecive example-set template containing all the log file samples in the folder

# Change Metamodel object at the end here if you want to put it in another example-set folder
set pretext "<?xml version="1.0" encoding="utf-8"?>
<AnalysisProgramOfRegionAnalysisSessionString xmlns:xsd="http://www.w3.org/2001/XMLSchema" 
xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
<SaveName>BuildFailureReason/"
# here add path to repo folder
set sectext "</SaveName>
<LearningData>
<InputPaths>"
# here add input paths as string
set trdtext "</InputPaths>
<Examples>"
# here add examples with inputPath & Output
set endtext "</Examples>
</LearningData>
<LogKind>
<Language>java</Language>
<BuildTool>android</BuildTool>
</LogKind>
<Target>BuildFailureReason</Target>
</AnalysisProgramOfRegionAnalysisSessionString>"


set prepath (string replace "/Users/Laci/Documents/Delft/master-thesis/tool/samples/" "" (pwd))/
set examplesetpath (echo (echo (string split / (pwd))[-3])"/"(echo (string split / (pwd))[-2]))
set filepath "../../../../example-sets/BuildFailureReason/"$examplesetpath".xml"

set -a inputpaths (for x in (ls .)
echo "<string>"$prepath$x"</string>"
end)




set -a examples (for x in (ls .)
echo "<ExampleDataOfString><InputPath>"$prepath$x"</InputPath><Output></Output></ExampleDataOfString>"
end)


touch $filepath
echo $pretext$examplesetpath$sectext >> $filepath
string join \n $inputpaths >> $filepath
echo $trdtext >> $filepath
string join \n $examples >> $filepath
echo $endtext >> $filepath
