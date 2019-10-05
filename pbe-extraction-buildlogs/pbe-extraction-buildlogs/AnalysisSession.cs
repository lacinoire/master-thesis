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

	/// <summary>
	/// Wrapper around PROSE Session for text extraction program synthesis
	/// </summary>
	/// <typeparam name="OutputType"></typeparam>
	public abstract class AnalysisSession<OutputType>
	{
		public abstract AnalysisSession<OutputType> AddInput(string inputPath);
		public abstract AnalysisSession<OutputType> AddExample(ExampleData<OutputType> exampleData);
		public abstract AnalysisSession<OutputType> AddCompletelyNegativeExample(string inputPath);
		public abstract AnalysisResult<OutputType> Analyze(string inputPath, AnalysisResult<OutputType> result, bool verbose);
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

		/// <summary>
		/// Analyze the file in <param name="inputPath"></param> using a program learned new from the currently present exampleset.
		/// </summary>
		/// <returns>The extraction result.</returns>
		public override AnalysisResult<string> Analyze(string inputPath, AnalysisResult<string> result, bool verbose)
		{
			ConsolePrinter consolePrinter = new ConsolePrinter(verbose);

			var inputRegion = AnalysisUtil.RegionFromFile(inputPath);

			consolePrinter.WriteLine("Starting to learn program");
			Stopwatch learningStopwatch = Stopwatch.StartNew();

			RegionProgram topRankedProgram = session.Learn();

			learningStopwatch.Stop();
			consolePrinter.WriteLine("Learning took " + learningStopwatch.Elapsed);
			result.LearningDuration = learningStopwatch.Elapsed;
			result.TestInputPath = inputPath;

			if (topRankedProgram == null)
			{
				consolePrinter.WriteLine("no program found");
				result.Successful = false;
				result.Output = "no program found";
				return result;
			}

			consolePrinter.WriteLine("Learned Program:");
			consolePrinter.WriteLine(topRankedProgram);
			consolePrinter.WriteLine("");
			result.LearnedProgram = topRankedProgram.ToString();

			consolePrinter.WriteLine("Starting to apply program");
			Stopwatch applyingStopwatch = Stopwatch.StartNew();

			StringRegion output = topRankedProgram.Run(inputRegion);

			applyingStopwatch.Stop();
			consolePrinter.WriteLine("Applying took " + applyingStopwatch.Elapsed);
			result.ApplicationDuration = applyingStopwatch.Elapsed;

			if (output == null)
			{
				result.Successful = false;
				result.Output = "no extraction found for this input";
				return result;
			}

			result.Successful = true;
			result.Output = output?.Value;
			return result;
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
				//	consolePrinter.Out.WriteLine(x.ReferenceKind.ToString() + " " + x.ProgramNode.PrintAST());
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

		public override AnalysisResult<string[]> Analyze(string inputPath, AnalysisResult<string[]> result, bool verbose)
		{
			var inputRegion = AnalysisUtil.RegionFromFile(inputPath);
			SequenceProgram topRankedProgram = session.Learn();
			if (topRankedProgram == null)
			{
				Console.Error.WriteLine("no program found");
				return null;
			}
			List<StringRegion> output = topRankedProgram.Run(inputRegion).ToList();
			result.Output = output.Select(o => o.Value).ToArray();
			return result;
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
				//	consolePrinter.Out.WriteLine(x.ReferenceKind.ToString() + " " + x.ProgramNode.PrintAST());
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
