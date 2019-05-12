using System;
using System.IO;
using BenchmarkDotNet.Running;
using Microsoft.ProgramSynthesis.DslLibrary;
using Microsoft.ProgramSynthesis.Extraction.Text;
using Microsoft.ProgramSynthesis.Extraction.Text.Constraints;

namespace pbeextractionbuildlogs
{
	/// <summary>
	/// Defines the CLI Parameter Interface
	/// </summary>
	class MainClass
	{
		public static void Main(string[] args)
		{
			if (args.Length == 1)
			{
				if (args[0] == "-bc")
				{
					new MicroBenchmarking().BenchmarkConnectbot();
				}
				else if (args[0] == "-b")
				{
					var summary = BenchmarkRunner.Run<MicroBenchmarking>();
					Console.WriteLine("Total Time: " + summary.TotalTime);
				}
				// TODO:
				// parameters for run -analysis, -performance (benchmark), -evaluation (both)
				// parameters for -file, -folder, -program
			}
			else
			{
				ConsoleInteraction.Run();
			}
		}

	}
}
