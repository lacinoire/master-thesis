using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.ProgramSynthesis.DslLibrary;
using Microsoft.ProgramSynthesis.Extraction.Text;
using Microsoft.ProgramSynthesis.Extraction.Text.Constraints;

namespace pbeextractionbuildlogs
{
	/// <summary>
	///  Invariant: Files do not move or disappear.
	/// </summary>
	public class AnalysisSession
	{
		public struct ExampleData
		{
			public string InputPath;
			public string Output;

			public ExampleData(string inputPath, string output)
			{
				this.InputPath = inputPath;
				this.Output = output;
			}
		}

		public class SessionData
		{
			public List<string> InputPaths = new List<string>();
			public List<ExampleData> Examples = new List<ExampleData>();
		}

		// TODO support sequence regions?
		private readonly RegionSession session = new RegionSession();
		private readonly Dictionary<string, StringRegion> fileCache = new Dictionary<string, StringRegion>();

		public AnalysisSession AddInput(string inputPath)
		{
			session.Inputs.Add(new[] { RegionFromFile(inputPath) });
			return this;
		}

		public AnalysisSession AddExample(ExampleData exampleData)
		{
			var inputRegion = RegionFromFile(exampleData.InputPath);
			var startIndex = inputRegion.S.IndexOf(exampleData.Output, StringComparison.Ordinal);
			var outputRegion = inputRegion.Slice((uint)startIndex, (uint)(startIndex + exampleData.Output.Length));
			session.Constraints.Add(new RegionExample(inputRegion, outputRegion));

			return this;
		}

		public string Analyze(string inputPath)
		{
			var inputRegion = RegionFromFile(inputPath);
			RegionProgram topRankedProgram = session.Learn();
			if (topRankedProgram == null)
			{
				Console.Error.WriteLine("no program found");
				return null;
			}
			StringRegion output = topRankedProgram.Run(inputRegion);
			return output?.Value;
		}

		public string CurrentProgram()
		{
			RegionProgram topRankedProgram = session.Learn();
			return topRankedProgram.Serialize();
		}

		public async Task<AnalysisSession> PrintSeparatingExamples()
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

		private StringRegion RegionFromFile(string path)
		{
			if (fileCache.ContainsKey(path))
			{
				return fileCache[path];
			}
			string text = File.ReadAllText(path);
			StringRegion region = RegionSession.CreateStringRegion(text);
			fileCache[path] = region;
			return region;
		}
	}
}
