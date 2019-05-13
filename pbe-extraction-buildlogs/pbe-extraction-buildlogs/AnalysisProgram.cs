using System;
using System.Collections.Generic;
using pbeextractionbuildlogs.MetaModel;
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

		/// <summary>
		/// Data needed for the learning lesson.
		/// </summary>
		public SessionData LearningData { get; }

		/// <summary>
		/// LogKind this programm analyzes
		/// </summary>
		public LogKind LogKind { get; }
		public MetaModelObject Target { get; }
		// MAYBE: private AnalysisSession analysisSession;

		public AnalysisProgram(string saveName, LogKind logKind, MetaModelObject target, SessionData learningData = new SessionData())
		{
			// TODO try to read from file first


			this.saveName = saveName;
			LearningData = learningData;
			LogKind = logKind;
			Target = target;
		}

		public AnalysisProgram AddInput(string inputPath)
		{

		}

		public AnalysisProgram AddExample(string inputPath, string output)
		{

		}

		public string ApplyToFile(string path)
		{

		}

		/// <summary>
		/// Give a verbose description of the whole program, the data is is based on, current status.
		/// </summary>
		/// <returns></returns>
		public string Describe()
		{

		}

		/// <summary>
		/// Shortly summarize the whole program.
		/// </summary>
		/// <returns></returns>
		public string Summarize()
		{

		}

		/// <summary>
		/// Save all the program data.
		/// </summary>
		public void Save()
		{

		}

		// TODO: Streaming API things for: adding examples (really again??), setting log kind, setting metamodelobject
		// THINK ABOUT: replace analysis session by this or keep separate? maybe only our specialities here and PROSE stuff still capsuled in AnalysisSession?

		// TODO: describe method that gives human-readable summary (short & long?)
		// TODO: apply method (instead of "generate program" method)
		// TODO: see whether PROSE Sessions can be usefully saved
	}
}
