using System;
using System.Linq;

namespace pbeextractionbuildlogs
{
	public class ConsoleOutput
	{
		public ConsoleOutput()
		{
		}

		public static string PrintAnalysisResult(AnalysisResult analysisResult, int indentation)
		{
			bool isFolder = analysisResult.FurtherResults.Count != 0;
			string output = Indentation(indentation) + PrintHeader(analysisResult, true, isFolder);

			if (isFolder)
			{
				output += analysisResult.FurtherResults.Select(ar => PrintAnalysisResult((AnalysisResult)ar, indentation + 1)).Aggregate((i, j) => i + "\n" + j);
			}
			else
			{
				output += Indentation(indentation + 1) + "Analysis " + (analysisResult.Successful ? "succeded" : "failed") + ".\n";
				output += Indentation(indentation + 1) + "Output was: " + analysisResult.Output + "\n";
				output += Indentation(indentation + 1) + "Desired output was: " + analysisResult.DesiredOutput + "\n";
			}

			return output;
		}

		public static string PrintBenchmarkResult(BenchmarkResult benchmarkResult)
		{
			string output = PrintHeader(benchmarkResult, false, benchmarkResult.FurtherResults.Count != 0);
			// TODO implement printing of benchmark results
			return output;
		}

		private static string PrintHeader(GeneralResult result, bool isAnalysis, bool isFolder)
		{
			return "Result of " + (isAnalysis ? "analyzing" : "benchmarking") + " the " + (isFolder ? "folder" : "file") + " " + result.Path + " with the program " + result.ProgramName + ":\n";
		}

		public static string PrintEvaluationResult(AnalysisResult analysisResult, BenchmarkResult benchmarkResult)
		{
			string output = "Result of analyzing and benchmarking " + analysisResult.Path;
			// TODO implement printing of evaluation results
			return output;
		}

		private static string Indentation(int indentation)
		{
			return new string(' ', indentation * 2);
		}
	}
}
