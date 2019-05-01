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

		public struct SessionData
		{
			public List<string> InputPaths;
			public List<ExampleData> Examples;
		}

		private readonly RegionSession session = new RegionSession();
		private SessionData data;
		private readonly Dictionary<string, StringRegion> fileCache = new Dictionary<string, StringRegion>();

		private const string SAVES_PATH = "../../../saves/";

		public AnalysisSession()
		{
			data.InputPaths = new List<string>();
			data.Examples = new List<ExampleData>();
		}

		public AnalysisSession AddInput(string inputPath)
		{
			data.InputPaths.Add(inputPath);
			session.Inputs.Add(new[] { RegionFromFile(inputPath) });
			return this;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>The bulider object.</returns>
		/// <param name="inputPath">Path to file that contains the example input.</param>
		/// <param name="output">Output. Has to be a substring of input.</param>
		public AnalysisSession AddExample(string inputPath, string output)
		{
			data.Examples.Add(new ExampleData(inputPath, output));

			var inputRegion = RegionFromFile(inputPath);
			var startIndex = inputRegion.S.IndexOf(output, StringComparison.Ordinal);
			var outputRegion = inputRegion.Slice((uint)startIndex, (uint)(startIndex + output.Length));
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

		public void Save(string name)
		{
			XmlSerializer serializer = new XmlSerializer(data.GetType());
			Directory.CreateDirectory(SAVES_PATH.Remove(SAVES_PATH.Length - 1));
			using (StreamWriter file = new StreamWriter(File.Create(SAVES_PATH + name + ".xml")))
			{
				serializer.Serialize(file, data);
			}
		}

		public static AnalysisSession Load(string name)
		{
			XmlSerializer serializer = new XmlSerializer(new SessionData().GetType());
			SessionData data;
			using (StreamReader file = new StreamReader(SAVES_PATH + name + ".xml"))
			{
				data = (SessionData)serializer.Deserialize(file);
			}
			AnalysisSession session = new AnalysisSession();
			data.InputPaths.ForEach(ip => session.AddInput(ip));
			data.Examples.ForEach(e => session.AddExample(e.InputPath, e.Output));
			return session;
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
