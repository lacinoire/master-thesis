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

		public ProgramCollection()
		{
			LoadProgramCollection();
		}

		private void LoadProgramCollection()
		{
			AnalysisPrograms.Add(AnalysisProgram<RegionAnalysisSession, string>.LoadAnalysisProgram("travis-worker"));
			AnalysisPrograms.Add(AnalysisProgram<RegionAnalysisSession, string>.LoadAnalysisProgram("travis-worker-short"));
			AnalysisPrograms.Add(AnalysisProgram<RegionAnalysisSession, string>.LoadAnalysisProgram("travis-worker-long"));
			AnalysisPrograms.Add(AnalysisProgram<RegionAnalysisSession, string>.LoadAnalysisProgram("android-failure"));
			AnalysisPrograms.Add(AnalysisProgram<RegionAnalysisSession, string>.LoadAnalysisProgram("android-failure-with-dependencies"));
			AnalysisPrograms.Add(AnalysisProgram<RegionAnalysisSession, string>.LoadAnalysisProgram("newline-test"));
		}

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

				//if (result.Output == null)
				//{
				//	result.Output = "Sadly we could not extract anything from that input";
				//}


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
	}
}
