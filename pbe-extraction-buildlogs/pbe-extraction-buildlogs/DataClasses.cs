using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace pbeextractionbuildlogs
{
	public class AnalysisResult<OutputType>
	{
		public string Path { get; set; }
		public string ProgramName { get; set; }
		public OutputType Output { get; set; }
		public OutputType DesiredOutput { get; set; }
		public bool Successful { get; set; }
		public TimeSpan LearningDuration { get; set; }
		public TimeSpan ApplicationDuration { get; set; }

		/// <summary>
		/// used for representing results of analyzed folders
		/// </summary>
		public List<AnalysisResult<OutputType>> FurtherResults { get; set; } = new List<AnalysisResult<OutputType>>();
	}

	public class EvaluationResult<OutputType>
	{
		public ExampleSelection ExampleSelection { get; set; }
		public string ProgramName { get; set; }
		public SerializableDictionary<SessionData<ExampleData<OutputType>>, List<AnalysisResult<OutputType>>> Results { get; set; } = new SerializableDictionary<SessionData<ExampleData<OutputType>>, List<AnalysisResult<OutputType>>>();
	}


	[XmlInclude(typeof(RandomSelection))]
	[XmlInclude(typeof(ChronologicalSelection))]
	[XmlInclude(typeof(ManualSelection))]
	public abstract class ExampleSelection
	{
		public bool IncludeAllInputs { get; set; }
		public int TestCount { get; set; }
		public int LearningStepCount { get; set; }
	}

	public class RandomSelection : ExampleSelection { }

	public class ChronologicalSelection : ExampleSelection { }

	public class ManualSelection : ExampleSelection { }



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
}
