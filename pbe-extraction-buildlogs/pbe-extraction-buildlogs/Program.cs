using System;
using System.IO;
using BenchmarkDotNet.Running;
using Microsoft.ProgramSynthesis.DslLibrary;
using Microsoft.ProgramSynthesis.Extraction.Text;
using Microsoft.ProgramSynthesis.Extraction.Text.Constraints;

namespace pbeextractionbuildlogs
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			if (args.Length == 1)
			{
				if (args[0] == "-bc")
				{
					new Benchmarking().BenchmarkConnectbot();
				}
				else if (args[0] == "-b")
				{
					var summary = BenchmarkRunner.Run<Benchmarking>();
					Console.WriteLine("Total Time: " + summary.TotalTime);
				}
			}
			else
			{
				ConsoleInteraction.Run();
			}
		}

	}
}
