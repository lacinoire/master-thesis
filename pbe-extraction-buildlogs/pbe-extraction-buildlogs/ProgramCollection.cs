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

	public class AnalysisResult<OutputType> : GeneralResult
	{
		public OutputType Output { get; set; }
		public OutputType DesiredOutput { get; set; }
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
		public List<NamedProgram> AnalysisPrograms = new List<NamedProgram>();

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
		public AnalysisResult<OutputType> Analyze<OutputType>(string programName, string path, bool mightBeFolder)
		{
			var result = new AnalysisResult<OutputType>();
			var wasFolder = false;
			if (mightBeFolder)
			{
				var tuple = IfPathIsFolderRunOnFolder(programName, path, Analyze<OutputType>);
				result.FurtherResults = tuple.Item1;
				wasFolder = tuple.Item2;
			}
			result.ProgramName = programName;
			result.Path = path;

			if (!wasFolder)
			{
				if (typeof(OutputType) == typeof(string))
				{
					var program = GetProgramForSaveName<RegionAnalysisSession, string>(programName);
					var output = program.ApplyToFile(path);
					result.Output = (OutputType)(object)output;
				}

				if (typeof(OutputType) == typeof(string[]))
				{
					var program = GetProgramForSaveName<SequenceAnalysisSession, string[]>(programName);
					var output = program.ApplyToFile(path);
					result.Output = (OutputType)(object)output;
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

		private AnalysisProgram<SessionType, OutputType> GetProgramForSaveName<SessionType, OutputType>(string name) where SessionType : AnalysisSession<OutputType>, new()
		{
			var program = AnalysisPrograms.Find(p => p.SaveName == name);
			if (program == null)
			{
				Console.WriteLine("No program found for identifier " + name);
			}
			return (pbeextractionbuildlogs.AnalysisProgram<SessionType, OutputType>)program;
		}

		public AnalysisProgram<RegionAnalysisSession, string> AddTravisWorkerProgram()
		{
			AnalysisProgram<RegionAnalysisSession, string> program = new AnalysisProgram<RegionAnalysisSession, string>("travis-worker", new LogKind("all", "all"), MetaModelObject.TravisWorker, takeFromFileIfPossible: false);
			program
				.AddExample("AdRoll@hologram/1_53661720_bcfe34b206aa75df8a1f6bee9153190bfcc6ca4b_53661722.log", "worker-linux-c55820f2-2.bb.travis-ci.org:travis-linux-11")
				.AddExample("AdRoll@hologram/3_53664779_e1988cc65bbe55e7930f29b4f5bed04af363dfcc_53664780.log", "worker-linux-c55820f2-1.bb.travis-ci.org:travis-linux-3")
				.AddExample("ant0ine@go-json-rest/1_5093969_e309d425737489de58a7a765aece0275f85cbb21_5093970.log", "ruby6.worker.travis-ci.org:travis-ruby-3");
			program.Save();
			AnalysisPrograms.Add(program);
			return program;
		}

		public AnalysisProgram<RegionAnalysisSession, string> AddAndroidBuildFailureProgram()
		{
			AnalysisProgram<RegionAnalysisSession, string> program = new AnalysisProgram<RegionAnalysisSession, string>("android-failure", new LogKind("java", "android"), MetaModelObject.BuildFailure, takeFromFileIfPossible: false);
			program
				.AddExample("connectbot@connectbot/3_6f3c306c9fbd6397ca529cc99154388c841e45b1_38381359.log", "Execution failed for task ':app:compileDebugNdk'.\n> NDK not configured.\n Download the NDK from http://developer.android.com/tools/sdk/ndk/.Then add ndk.dir=path/to/ndk in local.properties.\n  (On Windows, make sure you escape backslashes, e.g.C:\\ndk rather than C:\ndk)");
			program.Save();
			AnalysisPrograms.Add(program);
			return program;
		}
		// TODO: methods to fill with useful programs. Start with one for the TravisWorker
	}
}
