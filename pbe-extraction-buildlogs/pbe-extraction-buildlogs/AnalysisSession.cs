using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.ProgramSynthesis.DslLibrary;
using Microsoft.ProgramSynthesis.Extraction.Text;
using Microsoft.ProgramSynthesis.Extraction.Text.Constraints;
using Microsoft.ProgramSynthesis.Wrangling.Session;

namespace pbeextractionbuildlogs
{
	#region data-classes

	public class ExampleData<OutputType>
	{
		public string InputPath;
		public OutputType Output;

		public ExampleData() { }

		public ExampleData(string inputPath, OutputType output)
		{
			InputPath = inputPath;
			Output = output;
		}
	}

	public class SessionData<ExampleData>
	{
		public List<string> InputPaths = new List<string>();
		public List<ExampleData> Examples = new List<ExampleData>();
	}

	#endregion data-classes

	/// <summary>
	///  Invariant: Files do not move or disappear.
	/// </summary>
	///
	public static class AnalysisUtil
	{
		private static readonly Dictionary<string, StringRegion> fileCache = new Dictionary<string, StringRegion>();

		public static StringRegion RegionFromFile(string path)
		{
			if (fileCache.ContainsKey(path))
			{
				return fileCache[path];
			}
			string text = File.ReadAllText(path).Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n\r", "\n").Replace(((char)0x1b).ToString(), "");
			StringRegion region = RegionSession.CreateStringRegion(text);
			fileCache[path] = region;
			return region;
		}
	}

	public abstract class AnalysisSession<OutputType>
	{
		public abstract AnalysisSession<OutputType> AddInput(string inputPath);
		public abstract AnalysisSession<OutputType> AddExample(ExampleData<OutputType> exampleData);
		public abstract AnalysisSession<OutputType> AddCompletelyNegativeExample(string inputPath);
		public abstract OutputType Analyze(string inputPath);
		public abstract string CurrentProgram();
	}

	public class RegionAnalysisSession : AnalysisSession<string>
	{
		private readonly RegionSession session = new RegionSession();

		public override AnalysisSession<string> AddInput(string inputPath)
		{
			session.Inputs.Add(new[] { AnalysisUtil.RegionFromFile(inputPath) });
			return this;
		}

		public override AnalysisSession<string> AddExample(ExampleData<string> exampleData)
		{
			var inputRegion = AnalysisUtil.RegionFromFile(exampleData.InputPath);
			var startIndex = inputRegion.S.IndexOf(exampleData.Output, StringComparison.Ordinal);
			var outputRegion = inputRegion.Slice((uint)startIndex, (uint)(startIndex) + ((uint)exampleData.Output.Length));
			session.Constraints.Add(new RegionExample(inputRegion, outputRegion));

			return this;
		}

		/// <summary>
		/// including an example where nothing should be extracted, e.g. because the desired information is not present
		/// </summary>
		/// <param name="inputPath">the path to the example file</param>
		/// <returns></returns>
		public override AnalysisSession<string> AddCompletelyNegativeExample(string inputPath)
		{
			var inputRegion = AnalysisUtil.RegionFromFile(inputPath);
			session.Constraints.Add(new RegionNegativeExample(inputRegion, inputRegion));
			return this;
		}

		public override string Analyze(string inputPath)
		{
			var inputRegion = AnalysisUtil.RegionFromFile(inputPath);

			Console.WriteLine("Starting to learn program");
			Stopwatch learningStopwatch = Stopwatch.StartNew();
			RegionProgram topRankedProgram = session.Learn();
			learningStopwatch.Stop();
			Console.WriteLine("Learning took " + learningStopwatch.Elapsed);

			if (topRankedProgram == null)
			{
				Console.WriteLine("no program found");
				return "no program found";
			}
			Console.WriteLine("Learned Program:");
			Console.WriteLine(topRankedProgram);
			Console.WriteLine();

			Console.WriteLine("Starting to apply program");
			Stopwatch applyingStopwatch = Stopwatch.StartNew();
			StringRegion output = topRankedProgram.Run(inputRegion);
			applyingStopwatch.Stop();
			Console.WriteLine("Applying took " + applyingStopwatch.Elapsed);

			if (output == null)
			{
				return "no extraction found for this input";
			}
			return output?.Value;
		}

		public override string CurrentProgram()
		{
			RegionProgram topRankedProgram = session.Learn();
			return topRankedProgram.Serialize();
		}

		// MAYBE: redo separating examples
		public async Task<RegionAnalysisSession> PrintSeparatingExamples()
		{
			foreach (var sigInput in await session.GetSignificantInputsAsync())
			{
				Console.Out.WriteLine("Input[Confidence=" + sigInput.Confidence + "]: " + ((StringRegion[])sigInput.Input).Select(sr => sr.Value).Aggregate((i, j) => i + ", " + j));
				//foreach (var x in session.LearnTopK(5))
				//{
				//	Console.Out.WriteLine(x.ReferenceKind.ToString() + " " + x.ProgramNode.PrintAST());
				//}
				foreach (object output in await session.ComputeTopKOutputsAsync(sigInput.Input, 5))
				{
					Console.Out.WriteLine("Possible output: " + ((List<StringRegion>)output).Select(sr => sr.Value).Aggregate((i, j) => i + ", " + j));
				}
			}
			return this;
		}
	}

	public class SequenceAnalysisSession : AnalysisSession<string[]>
	{
		private readonly SequenceSession session = new SequenceSession();

		public override AnalysisSession<string[]> AddInput(string inputPath)
		{
			session.Inputs.Add(new[] { AnalysisUtil.RegionFromFile(inputPath) });
			return this;
		}

		public override AnalysisSession<string[]> AddExample(ExampleData<string[]> exampleData)
		{
			var inputRegion = AnalysisUtil.RegionFromFile(exampleData.InputPath);
			List<StringRegion> outputRegions = new List<StringRegion>();
			foreach (string output in exampleData.Output)
			{
				var startIndex = inputRegion.S.IndexOf(output, StringComparison.Ordinal);
				var outputRegion = inputRegion.Slice((uint)startIndex, (uint)(startIndex + output.Length));
				outputRegions.Add(outputRegion);
			}

			session.Constraints.Add(new SequenceExample(inputRegion, outputRegions));

			return this;
		}

		/// <summary>
		/// including an example where nothing should be extracted, e.g. because the desired information is not present
		/// </summary>
		/// <param name="inputPath">the path to the example file</param>
		/// <returns></returns>
		public override AnalysisSession<string[]> AddCompletelyNegativeExample(string inputPath)
		{
			var inputRegion = AnalysisUtil.RegionFromFile(inputPath);
			session.Constraints.Add(new SequenceNegativeExample(inputRegion, inputRegion));
			return this;
		}

		public override string[] Analyze(string inputPath)
		{
			var inputRegion = AnalysisUtil.RegionFromFile(inputPath);
			SequenceProgram topRankedProgram = session.Learn();
			if (topRankedProgram == null)
			{
				Console.Error.WriteLine("no program found");
				return null;
			}
			List<StringRegion> output = topRankedProgram.Run(inputRegion).ToList();
			return output.Select(o => o.Value).ToArray();
		}

		public override string CurrentProgram()
		{
			SequenceProgram topRankedProgram = session.Learn();
			return topRankedProgram.Serialize();
		}

		// MAYBE: redo separating examples
		public async Task<SequenceAnalysisSession> PrintSeparatingExamples()
		{
			foreach (var sigInput in await session.GetSignificantInputsAsync())
			{
				Console.Out.WriteLine("Input[Confidence=" + sigInput.Confidence + "]: " + ((StringRegion[])sigInput.Input).Select(sr => sr.Value).Aggregate((i, j) => i + ", " + j));
				//foreach (var x in session.LearnTopK(5))
				//{
				//	Console.Out.WriteLine(x.ReferenceKind.ToString() + " " + x.ProgramNode.PrintAST());
				//}
				foreach (object output in await session.ComputeTopKOutputsAsync(sigInput.Input, 5))
				{
					Console.Out.WriteLine("Possible output: " + ((List<StringRegion>)output).Select(sr => sr.Value).Aggregate((i, j) => i + ", " + j));
				}
			}
			return this;
		}
	}
}
