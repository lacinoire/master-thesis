using System;
using System.IO;
using BenchmarkDotNet.Running;
using CommandLine;

namespace pbeextractionbuildlogs
{
	/// <summary>
	/// Defines the CLI Parameter Interface
	/// </summary>
	class MainClass
	{
		public class Options
		{
			[Option('f', "file", HelpText = "Path of the file or folder to be analyzed")]
			public string Path { get; set; }

			[Option('p', "program", HelpText = "The program to run.")]
			public string ProgramName { get; set; }
		}

		[Verb("analyze", HelpText = "Analyze a program on the given path.")]
		public class AnalysisOptions : Options { }

		[Verb("benchmark", HelpText = "Benchmark a porgram on the given path.")]
		public class BenchmarkOptions : Options { }

		[Verb("evaluate", HelpText = "Analyze and benchmark a program on the given path.")]
		public class EvaluateOptions : Options { }

		[Verb("interaction", HelpText = "Launch the original console text interaction")]
		public class InteractionOptions { }

		public static void Main(string[] args)
		{
			// setup
			ProgramCollection programCollection = new ProgramCollection();

			Parser.Default.ParseArguments<AnalysisOptions, BenchmarkOptions, EvaluateOptions, InteractionOptions>(args)
				.WithParsed<AnalysisOptions>(opts => Analyze(opts, programCollection))
				.WithParsed<BenchmarkOptions>(opts => Benchmark(opts, programCollection))
				.WithParsed<EvaluateOptions>(opts => Evaluate(opts, programCollection))
				.WithParsed<InteractionOptions>(_ => ConsoleInteraction.Run())
				.WithNotParsed(errs => Console.WriteLine(errs));
		}

		private static void Analyze(AnalysisOptions opts, ProgramCollection programCollection)
		{
			Console.WriteLine(
				ConsoleOutput.PrintAnalysisResult(
					// FIXME distinguish between string and string[] here. Maybe with a simple mapping of prog names to output type
					programCollection.Analyze<string>(opts.ProgramName, Config.SAMPLE_DIRECTORY + opts.Path, true), 0));
		}

		private static void Benchmark(BenchmarkOptions opts, ProgramCollection programCollection)
		{
			Console.WriteLine(
				ConsoleOutput.PrintBenchmarkResult(
					programCollection.Benchmark(opts.ProgramName, Config.SAMPLE_DIRECTORY + opts.Path, true)));
		}

		private static void Evaluate(EvaluateOptions opts, ProgramCollection programCollection)
		{
			Console.WriteLine(
				ConsoleOutput.PrintEvaluationResult(
					programCollection.Analyze<string>(opts.ProgramName, Config.SAMPLE_DIRECTORY + opts.Path, true),
					programCollection.Benchmark(opts.ProgramName, Config.SAMPLE_DIRECTORY + opts.Path, true)));
		}

	}
}
