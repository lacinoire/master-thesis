using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
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
			[Option('p', "program", HelpText = "The program to run.")]
			public string ProgramName { get; set; }
		}

		[Verb("analyze", HelpText = "Analyze the object at the given path.")]
		public class AnalysisOptions : Options
		{
			[Option('f', "file", HelpText = "Path of the file or folder to be analyzed")]
			public string Path { get; set; }

			[Option('v', "verbose", HelpText = "Output detailed information and intermediate results instead of just the extraction result")]
			public bool Verbose { get; set; }
		}

		[Verb("evaluate", HelpText = "Evaluate the learning of a given exampleset.")]
		public class EvaluateOptions : Options
		{
			[Option('s', "selection", HelpText = "How examples for iterated learning should be seleced. Either 'random',  'chronological' or 'sequence' (taking the sequence in the example set configuration).")]
			public string ExampleSelection { get; set; }

			[Option('i', "include-inputs", HelpText = "Include all avaliable input paths as inputs in the learning process. Default: only files from examples are considered as possible inputs.")]
			public bool IncludeAllInputs { get; set; }

			[Option('t', "test-count", HelpText = "On how many following examples the learned programs should be evaluated.")]
			public int TestCount { get; set; }

			[Option('l', "learning-step-count", HelpText = "How many examples should maximally be used for learning during the evaluation.")]
			public int LearningStepCount { get; set; }
		}

		[Verb("interaction", HelpText = "Launch the original console text interaction")]
		public class InteractionOptions { }

		private List<string> SequenceAnalysisSessionProgramNames = new List<string>();

		public static void Main(string[] args)
		{
			Parser.Default.ParseArguments<AnalysisOptions, EvaluateOptions, InteractionOptions>(args)
				.WithParsed<AnalysisOptions>(opts => RunAnalysis(opts))
				.WithParsed<EvaluateOptions>(opts => RunEvaluation(opts))
				.WithParsed<InteractionOptions>(_ => ConsoleInteraction.Run())
				.WithNotParsed(errs => Console.WriteLine(errs));
		}

		private static void RunAnalysis(AnalysisOptions opts)
		{
			Console.WriteLine(
				ConsoleOutput.PrintAnalysisResult(
					// FIXME distinguish between string and string[] here. Maybe with a simple mapping of prog names to output type
					Analyze<string>(opts.ProgramName, Config.SAMPLE_DIRECTORY + opts.Path, opts.Verbose, true), 0, opts.Verbose));
		}

		private static void RunEvaluation(EvaluateOptions opts)
		{
			ExampleSelection exampleSelection;
			switch (opts.ExampleSelection)
			{
				case "random":
					exampleSelection = new RandomSelection();
					break;
				case "chronological":
					exampleSelection = new ChronologicalSelection();
					break;
				case "manual":
					exampleSelection = new ManualSelection();
					break;
				default:
					throw new ArgumentException("Selection mode should be either 'random', 'chronological' or 'manual'");
			}

			exampleSelection.IncludeAllInputs = opts.IncludeAllInputs;
			exampleSelection.TestCount = opts.TestCount;
			exampleSelection.LearningStepCount = opts.LearningStepCount;
			var result = Evaluate<string>(opts.ProgramName, exampleSelection);
			SaveEvaluationResult(result);
		}

		/// <summary>
		/// Run analysis of a program on the given path.
		/// </summary>
		/// <param name="programName"></param>
		/// <param name="path"></param>
		/// <param name="mightBeFolder"></param>
		/// <returns></returns>
		public static AnalysisResult<OutputType> Analyze<OutputType>(string programName, string path, bool verbose, bool mightBeFolder)
		{
			// TODO: proposal: Method just like this which just gives a "learning/evaluation result" back, packed with the example selection technique and a sequence of analysis results spun together with some information on which samples were used
			var result = new AnalysisResult<OutputType>();
			var wasFolder = false;
			if (mightBeFolder)
			{
				var tuple = IfPathIsFolderRunOnFolder(programName, path, verbose, Analyze<OutputType>);
				result.FurtherResults = tuple.Item1;
				wasFolder = tuple.Item2;
			}
			result.ProgramName = programName;
			result.Path = path;

			if (!wasFolder)
			{
				if (typeof(OutputType) == typeof(string))
				{
					var program = AnalysisProgram<RegionAnalysisSession, string>.LoadAnalysisProgram(programName);
					program.ApplyToFile(path, (AnalysisResult<string>)(object)result, verbose);
				}

				if (typeof(OutputType) == typeof(string[]))
				{
					var program = AnalysisProgram<SequenceAnalysisSession, string[]>.LoadAnalysisProgram(programName);
					program.ApplyToFile(path, (AnalysisResult<string[]>)(object)result, verbose);
				}

				// TODO get desired output from somewhere
				result.DesiredOutput = result.Output;
				result.Successful = result.DesiredOutput.Equals(result.Output);
			}
			else
			{
				result.Successful = true;
			}

			return result;
		}

		public static EvaluationResult<OutputType> Evaluate<OutputType>(string programName, ExampleSelection exampleSelection)
		{
			var result = new EvaluationResult<OutputType>();
			result.ExampleSelection = exampleSelection;
			result.ProgramName = programName;
			if (typeof(OutputType) == typeof(string))
			{
				var program = AnalysisProgram<RegionAnalysisSession, string>.LoadAnalysisProgram(programName);
				return (EvaluationResult<OutputType>)(object)program.Evaluate(exampleSelection, (EvaluationResult<string>)(object)result);
			}
			if (typeof(OutputType) == typeof(string[]))
			{
				var program = AnalysisProgram<SequenceAnalysisSession, string[]>.LoadAnalysisProgram(programName);
				return (EvaluationResult<OutputType>)(object)program.Evaluate(exampleSelection, (EvaluationResult<string[]>)(object)result);
			}
			return result;
		}

		/// <summary>
		/// If the given path references a folder all files inside are processed by function and the results given back in a list, additionally true is returned. If the path leads to a file an empty list and false is returned.
		/// </summary>
		/// <param name="programName"></param>
		/// <param name="path"></param>
		/// <param name="function"></param>
		/// <returns></returns>
		private static (List<AnalysisResult<OutputType>>, bool) IfPathIsFolderRunOnFolder<OutputType>(string programName, string path, bool verbose, Func<string, string, bool, bool, AnalysisResult<OutputType>> function)
		{
			FileAttributes attr = File.GetAttributes(path);
			if (attr.HasFlag(FileAttributes.Directory))
			{
				return (Directory.EnumerateFiles(path).Select(p => function(programName, p, false, verbose)).ToList(), true);
			}
			return (new List<AnalysisResult<OutputType>>(), false);
		}


		private static void SaveEvaluationResult<OutputType>(EvaluationResult<OutputType> result)
		{
			XmlSerializer serializer = new XmlSerializer(result.GetType());
			Directory.CreateDirectory(
				Config.RESULT_DIRECTORY.Remove(Config.RESULT_DIRECTORY.Length - 1));
			var progSaveName = result.ProgramName.Replace("/", "@");
			using (StreamWriter file = new StreamWriter(File.Create(Config.RESULT_DIRECTORY + progSaveName + "-" + "pbe" + "-" + result.ExampleSelection.Name + "-" + result.ExampleSelection.LearningStepCount + "-" + result.ExampleSelection.TestCount + ".xml")))
			{
				serializer.Serialize(file, result);
			}
		}
	}
}
