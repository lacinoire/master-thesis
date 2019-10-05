using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace pbeextractionbuildlogs
{
	public class AnalysisResult<OutputType>
	{
		public string Path { get; set; }
		public string ProgramName { get; set; }
		public string LearnedProgram { get; set; }
		public string TestInputPath { get; set; }
		public OutputType Output { get; set; }
		public OutputType DesiredOutput { get; set; }
		public bool Successful { get; set; }
		public string AllKeywords { get; set; }
		public string Categories { get; set; }

		[XmlIgnore]
		public TimeSpan LearningDuration { get; set; }

		[XmlElement("LearningDuration")]
		public long LearningDurationSubstitute
		{
			get
			{
				return LearningDuration.Ticks;
			}
			set
			{
				LearningDuration = TimeSpan.FromTicks(value);
			}
		}

		[XmlIgnore]
		public TimeSpan ApplicationDuration { get; set; }

		[XmlElement("ApplicationDuration")]
		public long ApplicationDurationSubstitute
		{
			get
			{
				return ApplicationDuration.Ticks;
			}
			set
			{
				ApplicationDuration = TimeSpan.FromTicks(value);
			}
		}

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
		public abstract string Name { get; }
	}

	public class RandomSelection : ExampleSelection
	{
		public override string Name => "random";
	}

	public class ChronologicalSelection : ExampleSelection
	{
		public override string Name => "chronological";
	}

	public class ManualSelection : ExampleSelection
	{
		public override string Name => "manual";
	}



	public class ExampleData<OutputType>
	{
		public string InputPath;
		public OutputType Output;
		public string Keywords;
		public string Category;

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
