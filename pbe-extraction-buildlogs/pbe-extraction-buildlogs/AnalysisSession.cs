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
			public string inputPath;
			public string output;

			public ExampleData(string inputPath, string output)
			{
				this.inputPath = inputPath;
				this.output = output;
			}
		}

		public struct SessionData
		{
			public List<string> inputPaths;
			public List<ExampleData> examples;
		}

		private RegionSession session;
		private SessionData data;
		private Dictionary<string, StringRegion> fileCache;

		private const string SAMPLE_PATH = "../../../samples/";
		private const string SAVES_PATH = "../../../saves/";

		public AnalysisSession()
		{
			session = new RegionSession();
			data.inputPaths = new List<string>();
			data.examples = new List<ExampleData>();
			fileCache = new Dictionary<string, StringRegion>();
		}

		public AnalysisSession AddInput(string inputPath)
		{
			data.inputPaths.Add(inputPath);
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
			data.examples.Add(new ExampleData(inputPath, output));

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
			data.inputPaths.ForEach(ip => session.AddInput(ip));
			data.examples.ForEach(e => session.AddExample(e.inputPath, e.output));
			return session;
		}

		public async Task<AnalysisSession> PrintSeparatingExamples()
		{
			foreach (var sigInput in await session.GetSignificantInputsAsync())
			{
				Console.Out.WriteLine("Input[Confidence=" + sigInput.Confidence + "]: " + ((StringRegion[])sigInput.Input).Select(sr => sr.Value).Aggregate((i, j) => i + ", " + j));
				foreach (var x in session.LearnTopK(5))
				{
					Console.Out.WriteLine(x.Score + " " + x.Serialize());
				}
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
			string text = File.ReadAllText(SAMPLE_PATH + path);
			StringRegion region = RegionSession.CreateStringRegion(text);
			fileCache[path] = region;
			return region;
		}
	}
}
