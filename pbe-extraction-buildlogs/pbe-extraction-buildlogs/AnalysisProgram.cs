using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using static pbeextractionbuildlogs.AnalysisSession;

namespace pbeextractionbuildlogs
{
	/// <summary>
	/// Represents one learnt/learnable Program
	/// </summary>
	public class AnalysisProgram
	{
		/// <summary>
		/// Filename to save the corresponding data under.
		/// </summary>
		string saveName;
		string saveFilePath => Config.PROGRAM_DATA_DIRECTORY + saveName + ".xml";

		AnalysisSession analysisSession;

		/// <summary>
		/// Data needed for the learning lesson.
		/// </summary>
		public SessionData LearningData { get; private set; }

		/// <summary>
		/// LogKind this programm analyzes
		/// </summary>
		public LogKind LogKind { get; }

		/// <summary>
		/// TODO: enum?
		/// </summary>
		public MetaModelObject Target { get; }
		// MAYBE: private AnalysisSession analysisSession;

		public AnalysisProgram(string saveName, LogKind logKind, MetaModelObject target, SessionData learningData = new SessionData(), bool takeFromFileIfPossible = false)
		{
			if (takeFromFileIfPossible && File.Exists(Config.PROGRAM_DATA_DIRECTORY + saveName + ".xml"))
			{
				Load();
			}
			else
			{
				LearningData = learningData;
			}

			this.saveName = saveName;
			LogKind = logKind;
			Target = target;
		}

		public AnalysisProgram AddOnlyInput(string inputPath)
		{
			LearningData.InputPaths.Add(inputPath);
			return this;
		}

		public AnalysisProgram AddWholeFolderAsInput(string folderPath)
		{
			throw new NotImplementedException();
		}

		public AnalysisProgram AddExample(string inputPath, string output)
		{
			LearningData.InputPaths.Add(inputPath);
			LearningData.Examples.Add(new ExampleData(inputPath, output));
			return this;
		}

		public string ApplyToFile(string path)
		{
			// TODO create (if not already present) analysis session and fill with data
			if (analysisSession == null)
			{
				analysisSession = new AnalysisSession();
				LearningData.InputPaths.ForEach(ip => analysisSession.AddInput(ip));
				LearningData.Examples.ForEach(ex => analysisSession.AddExample(ex));
			}
			return analysisSession.Analyze(path);
		}

		/// <summary>
		/// Give a verbose description of the whole program, the data is is based on, current status.
		/// </summary>
		/// <returns></returns>
		public string Describe()
		{
			string output = "Program " + this.saveName + ", analyzing " + Target + " in buildlog kind " + LogKind + "\n";
			output += "Program is " + (analysisSession == null ? "not " : "") + "learned\n";
			output += "Examples are:\n";
			LearningData.Examples.ForEach(ex => output += "  path: " + ex.InputPath + ", output: " + ex.Output + "\n");
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
			string output = "Program " + this.saveName + ", analyzing " + Target + " in buildlog kind " + LogKind + ", ";
			output += "Program is " + (analysisSession == null ? "not " : "") + "learned, ";
			output += "Example count: " + LearningData.Examples.Count + ", Input count: " + LearningData.InputPaths.Count;
			return output;
		}

		/// <summary>
		/// Save all the program data.
		/// </summary>
		public void Save()
		{
			XmlSerializer serializer = new XmlSerializer(LearningData.GetType());
			Directory.CreateDirectory(Config.PROGRAM_DATA_DIRECTORY.Remove(Config.PROGRAM_DATA_DIRECTORY.Length - 1));
			using (StreamWriter file = new StreamWriter(File.Create(saveFilePath)))
			{
				serializer.Serialize(file, LearningData);
			}
		}

		public void Load()
		{
			XmlSerializer serializer = new XmlSerializer(new SessionData().GetType());
			using (StreamReader file = new StreamReader(saveFilePath))
			{
				LearningData = (SessionData)serializer.Deserialize(file);
			}
		}

		// TODO: see whether PROSE Sessions can be usefully saved
	}
}
