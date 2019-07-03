using System;
using System.Linq;

namespace pbeextractionbuildlogs
{
	public class ConsoleOutput
	{
		public static string PrintAnalysisResult<OutputType>(AnalysisResult<OutputType> analysisResult, int indentation)
		{
			bool isFolder = analysisResult.FurtherResults.Count != 0;
			string output = Indentation(indentation) + PrintHeader(analysisResult, true, isFolder);

			if (isFolder)
			{
				output += analysisResult.FurtherResults.Select(ar => PrintAnalysisResult((AnalysisResult<OutputType>)ar, indentation + 1)).Aggregate((i, j) => i + "\n" + j);
			}
			else
			{
				output += Indentation(indentation + 1) + "Analysis " + (analysisResult.Successful ? "succeded" : "failed") + ".\n";
				output += Indentation(indentation + 1) + "Output was: " + PrintOutput(analysisResult.Output) + "\n";
				output += Indentation(indentation + 1) + "Desired output was: " + PrintOutput(analysisResult.DesiredOutput) + "\n";
			}

			return output;
		}

		private static string PrintHeader<OutputType>(AnalysisResult<OutputType> result, bool isAnalysis, bool isFolder)
		{
			return "Result of " + (isAnalysis ? "analyzing" : "benchmarking") + " the " + (isFolder ? "folder" : "file") + " " + result.Path + " with the program " + result.ProgramName + ":\n";
		}

		private static string Indentation(int indentation)
		{
			return new string(' ', indentation * 2);
		}

		private static string PrintOutput<OutputType>(OutputType output)
		{
			if (typeof(OutputType) == typeof(string))
			{
				return (string)(object)output;
			}
			if (typeof(OutputType) == typeof(string[]))
			{
				return ((string[])(object)output).Aggregate((i, j) => i + "\n----next sequence instance----\n" + j);
			}
			return "error! only string and string[] supported at output for printing!";
		}
	}
}
