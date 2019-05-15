using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace pbeextractionbuildlogs
{
	public class GeneralResult
	{
		public string Path { get; set; }
		public string ProgramName { get; set; }
		public List<GeneralResult> FurtherResults { get; set; } = new List<GeneralResult>();
	}

	public class AnalysisResult : GeneralResult
	{
		public string Output { get; set; }
		public string DesiredOutput { get; set; }
		public bool Successful { get; set; }
	}

	public class BenchmarkResult : GeneralResult
	{
		public TimeSpan Duration { get; set; }
	}

	/// <summary>
	/// Holds all the different programs this tool learnt for extracting information.
	/// </summary>
	public class ProgramCollection
	{
		public List<AnalysisProgram> AnalysisPrograms = new List<AnalysisProgram>();

		/// <summary>
		/// If the given path references a folder all files inside are processed by function and the results given back in a list, additionally true is returned. If the path leads to a file an empty list and false is returned.
		/// </summary>
		/// <param name="programName"></param>
		/// <param name="path"></param>
		/// <param name="function"></param>
		/// <returns></returns>
		private (List<GeneralResult>, bool) IfPathIsFolderRunOnFolder(string programName, string path, Func<string, string, bool, GeneralResult> function)
		{
			FileAttributes attr = File.GetAttributes(path);
			if (attr.HasFlag(FileAttributes.Directory))
			{
				return (Directory.EnumerateFiles(path).Select(p => function(programName, p, false)).ToList(), true);
			}
			return (new List<GeneralResult>(), false);
		}

		/// <summary>
		/// Run analysis of a program on the given path.
		/// </summary>
		/// <param name="programName"></param>
		/// <param name="path"></param>
		/// <param name="mightBeFolder"></param>
		/// <returns></returns>
		public AnalysisResult Analyze(string programName, string path, bool mightBeFolder)
		{
			var result = new AnalysisResult();
			var wasFolder = false;
			if (mightBeFolder)
			{
				var tuple = IfPathIsFolderRunOnFolder(programName, path, Analyze);
				result.FurtherResults = tuple.Item1;
				wasFolder = tuple.Item2;
			}
			result.ProgramName = programName;
			result.Path = path;

			if (!wasFolder)
			{
				var program = GetProgramForSaveName(programName);
				var output = program.ApplyToFile(path);
				result.Output = output;

				// TODO get desired output from somewhere
				result.DesiredOutput = result.Output;
				result.Successful = result.DesiredOutput == result.Output;
			}
			else
			{
				result.Successful = true;
			}

			return result;
		}

		/// <summary>
		/// Run benchmark of a program on the given path.
		/// </summary>
		/// <param name="programName"></param>
		/// <param name="path"></param>
		/// <param name="mightBeFolder"></param>
		/// <returns></returns>
		public BenchmarkResult Benchmark(string programName, string path, bool mightBeFolder)
		{
			var result = new BenchmarkResult();
			var wasFolder = false;
			if (mightBeFolder)
			{
				var tuple = IfPathIsFolderRunOnFolder(programName, path, Benchmark);
				result.FurtherResults = tuple.Item1;
				wasFolder = tuple.Item2;
			}
			// TODO measure time, average over 5 executions
			return result;
		}

		private AnalysisProgram GetProgramForSaveName(string name)
		{
			var program = AnalysisPrograms.Find(p => p.SaveName == name);
			if (program == null)
			{
				Console.WriteLine("No program found for identifier " + name);
			}
			return program;
		}

		public AnalysisProgram AddTravisWorkerProgram()
		{
			AnalysisProgram program = new AnalysisProgram("travis-worker", new LogKind("all", "all"), MetaModelObject.TravisWorker, takeFromFileIfPossible: false);
			program
				.AddExample("AdRoll@hologram/1_53661720_bcfe34b206aa75df8a1f6bee9153190bfcc6ca4b_53661722.log", "worker-linux-c55820f2-2.bb.travis-ci.org:travis-linux-11")
				.AddExample("AdRoll@hologram/3_53664779_e1988cc65bbe55e7930f29b4f5bed04af363dfcc_53664780.log", "worker-linux-c55820f2-1.bb.travis-ci.org:travis-linux-3")
				.AddExample("ant0ine@go-json-rest/1_5093969_e309d425737489de58a7a765aece0275f85cbb21_5093970.log", "ruby6.worker.travis-ci.org:travis-ruby-3");
			program.Save();
			AnalysisPrograms.Add(program);
			return program;
		}
		// TODO: methods to fill with useful programs. Start with one for the TravisWorker
	}
}
