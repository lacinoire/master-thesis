using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace pbeextractionbuildlogs
{

	/// <summary>
	/// Represents one learnt/learnable Type of Program, with all possible examples and inputs used for learning and evaluation
	/// </summary>
	public class AnalysisProgram<SessionType, OutputType> where
		SessionType : AnalysisSession<OutputType>, new()
	{
		public string SaveName { get; set; }

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
		/// The Information Item extracted by this program
		/// </summary>
		public MetaModelObject Target { get; set; }



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



		public AnalysisResult<OutputType> ApplyToFile(string path, AnalysisResult<OutputType> result, bool verbose)
		{
			return ApplyToFileWithLearningData(path, LearningData, result, verbose);
		}

		private AnalysisResult<OutputType> ApplyToFileWithLearningData(string path, SessionData<ExampleData<OutputType>> learningData, AnalysisResult<OutputType> result, bool verbose)
		{

			// TODO not redo session & learning if examples did not change
			analysisSession = new SessionType();

			learningData.InputPaths.ForEach(ip => analysisSession.AddInput(Config.SAMPLE_DIRECTORY + ip));
			learningData.Examples.ForEach(ex => analysisSession.AddExample(new ExampleData<OutputType>(Config.SAMPLE_DIRECTORY + ex.InputPath, ex.Output)));

			if (verbose)
			{
				//Console.WriteLine(Summarize(learningData));
			}

			result.AllKeywords = string.Join(", ", learningData.Examples.Select(ex => ex.Keywords));
			result.Categories = string.Join("-", learningData.Examples.Select(ex => ex.Category));

			return analysisSession.Analyze(path, result, verbose);
		}

		public EvaluationResult<OutputType> Evaluate(ExampleSelection exampleSelection,
			EvaluationResult<OutputType> result)
		{

			if (exampleSelection is RandomSelection)
			{
				// randomize list of examples
				LearningData.Examples.Shuffle();
			}
			else if (exampleSelection is ChronologicalSelection)
			{
				// input path of example cut off after last slash and remove .log then sort by that.
				LearningData.Examples.Sort((ex1, ex2) => GetBuildIdFromPath(ex1.InputPath).CompareTo(GetBuildIdFromPath(ex2.InputPath)));
			}
			else if (exampleSelection is ManualSelection)
			{
				// take examples in list they are defined in file (so sequence they have in the LearningData already)
			}

			for (int exampleCount = 1; exampleCount <= exampleSelection.LearningStepCount; exampleCount++)
			{
				SessionData<ExampleData<OutputType>> currentLearningData = new SessionData<ExampleData<OutputType>>();
				currentLearningData.Examples = LearningData.Examples.GetRange(0, Math.Min(exampleCount, LearningData.Examples.Count));
				if (exampleSelection.IncludeAllInputs)
				{
					currentLearningData.InputPaths = LearningData.InputPaths;
				}
				List<ExampleData<OutputType>> testSamples = LearningData.Examples.GetRange(exampleCount, Math.Min(exampleSelection.TestCount, LearningData.Examples.Count - exampleCount));
				List<AnalysisResult<OutputType>> testResults = new List<AnalysisResult<OutputType>>();
				foreach (ExampleData<OutputType> testSample in testSamples)
				{
					var analysisResult = ApplyToFileWithLearningData(Config.SAMPLE_DIRECTORY + testSample.InputPath, currentLearningData, new AnalysisResult<OutputType>(), true);
					analysisResult.DesiredOutput = testSample.Output;
					Console.WriteLine(ConsoleOutput.PrintAnalysisResult(analysisResult, 0, true));
					testResults.Add(analysisResult);
				}
				result.Results.Add(currentLearningData, testResults);
			}

			return result;
		}

		private int GetBuildIdFromPath(string path)
		{
			return int.Parse(path.Split('/').Last().Split('.').First());
		}


		/// <summary>
		/// Give a verbose description of the whole program, the data is is based on, current status.
		/// </summary>
		/// <returns></returns>
		public string Describe(SessionData<ExampleData<OutputType>> learningData)
		{
			string output = "Program " + SaveName + ", analyzing " + Target + " in buildlog kind " + LogKind + "\n";
			output += "Examples are:\n";
			learningData.Examples.ForEach(ex => output += "  path: " + ex.InputPath + ", output: " + ex.Output + "\n");
			// TODO: fix output if OutputType is string[]
			output += "Inputs are:\n";
			learningData.InputPaths.ForEach(ip => output += "  path: " + ip + "\n");

			// TODO: humanreadable output of learned program if program is learned

			return output;
		}

		/// <summary>
		/// Shortly summarize the whole program.
		/// </summary>
		/// <returns></returns>
		public string Summarize(SessionData<ExampleData<OutputType>> learningData)
		{
			string output = "Program " + SaveName + ", analyzing " + Target + " in buildlog kind " + LogKind + ", ";
			output += "Example count: " + learningData.Examples.Count + ", Input count: " + learningData.InputPaths.Count;
			return output;
		}

		/// <summary>
		/// Save all the program data.
		/// </summary>
		public void Save()
		{
			XmlSerializer serializer = new XmlSerializer(GetType());
			Directory.CreateDirectory(
				Config.PROGRAM_DATA_DIRECTORY.Remove(Config.PROGRAM_DATA_DIRECTORY.Length - 1));
			using (StreamWriter file = new StreamWriter(File.Create(saveFilePath)))
			{
				serializer.Serialize(file, this);
			}
		}

		public AnalysisProgram<SessionType, OutputType> Load()
		{
			XmlSerializer serializer = new XmlSerializer(GetType());
			string text = Util.NormalizeBuildLogString(File.ReadAllText(saveFilePath));
			using (TextReader reader = new StringReader(text))
			{
				return (AnalysisProgram<SessionType, OutputType>)serializer.Deserialize(reader);
			}
		}

		// TODO: see whether PROSE Sessions can be usefully saved
	}
}
