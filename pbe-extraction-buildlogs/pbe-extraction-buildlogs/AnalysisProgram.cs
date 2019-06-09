using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace pbeextractionbuildlogs
{
	public class NamedProgram
	{
		/// <summary>
		/// Filename to save the corresponding data under.
		/// </summary>
		public string SaveName { get; set; }
	}

	/// <summary>
	/// Represents one learnt/learnable Program
	/// </summary>
	public class AnalysisProgram<SessionType, OutputType> : NamedProgram where SessionType : AnalysisSession<OutputType>, new()
	{
		string saveFilePath => Config.PROGRAM_DATA_DIRECTORY + SaveName + ".xml";

		SessionType analysisSession;

		/// <summary>
		/// Data needed for the learning lesson.
		/// </summary>
		public SessionData<ExampleData<OutputType>> LearningData { get; set; }

		/// <summary>
		/// LogKind this programm analyzes
		/// </summary>
		public LogKind LogKind { get; set; }

		/// <summary>
		/// TODO doc
		/// </summary>
		public MetaModelObject Target { get; set; }
		// MAYBE: private AnalysisSession analysisSession;

		public static AnalysisProgram<SessionType, OutputType> LoadAnalysisProgram(string saveName)
		{
			return (new AnalysisProgram<SessionType, OutputType>
			{
				SaveName = saveName,
			}).Load();
		}

		public AnalysisProgram() { }

		public AnalysisProgram(string saveName, LogKind logKind, MetaModelObject target, SessionData<ExampleData<OutputType>> learningData = null, bool takeFromFileIfPossible = false)
		{
			if (learningData == null)
			{
				learningData = new SessionData<ExampleData<OutputType>>();
			}

			if (takeFromFileIfPossible && File.Exists(Config.PROGRAM_DATA_DIRECTORY + SaveName + ".xml"))
			{
				Load();
			}
			else
			{
				LearningData = learningData;
			}

			SaveName = saveName;
			LogKind = logKind;
			Target = target;
		}

		public AnalysisProgram<SessionType, OutputType> AddOnlyInput(string inputPath)
		{
			LearningData.InputPaths.Add(inputPath);
			return this;
		}

		public AnalysisProgram<SessionType, OutputType> AddWholeFolderAsInput(string folderPath)
		{
			throw new NotImplementedException();
		}

		public AnalysisProgram<SessionType, OutputType> AddExample(string inputPath, OutputType output)
		{
			LearningData.InputPaths.Add(inputPath);
			LearningData.Examples.Add(new ExampleData<OutputType>(inputPath, output));
			return this;
		}

		public OutputType ApplyToFile(string path)
		{

			// TODO not redo session & learning if examples did not change
			analysisSession = new SessionType();
			LearningData.InputPaths.ForEach(ip => analysisSession.AddInput(Config.SAMPLE_DIRECTORY + ip));
			LearningData.Examples.ForEach(ex => analysisSession.AddExample(new ExampleData<OutputType>(Config.SAMPLE_DIRECTORY + ex.InputPath, ex.Output)));
			// FIXME Fix that path prefix thing
			return analysisSession.Analyze(path);
		}

		/// <summary>
		/// Give a verbose description of the whole program, the data is is based on, current status.
		/// </summary>
		/// <returns></returns>
		public string Describe()
		{
			string output = "Program " + SaveName + ", analyzing " + Target + " in buildlog kind " + LogKind + "\n";
			output += "Program is " + (analysisSession == null ? "not " : "") + "learned\n";
			output += "Examples are:\n";
			LearningData.Examples.ForEach(ex => output += "  path: " + ex.InputPath + ", output: " + ex.Output + "\n");
			// TODO: fix output if OutputType is string[]
			output += "Inputs are:\n";
			LearningData.InputPaths.ForEach(ip => output += "  path: " + ip + "\n");

			// TODO: humanreadable output of learned program if program is learned

			return output;
		}

		/// <summary>
		/// Shortly summarize the whole program.
		/// </summary>
		/// <returns></returns>
		public string Summarize()
		{
			string output = "Program " + SaveName + ", analyzing " + Target + " in buildlog kind " + LogKind + ", ";
			output += "Program is " + (analysisSession == null ? "not " : "") + "learned, ";
			output += "Example count: " + LearningData.Examples.Count + ", Input count: " + LearningData.InputPaths.Count;
			return output;
		}

		/// <summary>
		/// Save all the program data.
		/// </summary>
		public void Save()
		{
			XmlSerializer serializer = new XmlSerializer(GetType());
			Directory.CreateDirectory(Config.PROGRAM_DATA_DIRECTORY.Remove(Config.PROGRAM_DATA_DIRECTORY.Length - 1));
			using (StreamWriter file = new StreamWriter(File.Create(saveFilePath)))
			{
				serializer.Serialize(file, this);
			}
		}

		public AnalysisProgram<SessionType, OutputType> Load()
		{
			// TODO: auch andere sachen serializieren??
			XmlSerializer serializer = new XmlSerializer(GetType());
			using (StreamReader file = new StreamReader(saveFilePath))
			{
				return (AnalysisProgram<SessionType, OutputType>)serializer.Deserialize(file);
			}
		}

		// TODO: see whether PROSE Sessions can be usefully saved
	}
}
