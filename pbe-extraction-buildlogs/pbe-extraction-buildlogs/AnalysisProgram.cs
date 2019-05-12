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
		string saveName;
		public SessionData LearningData { get; }
		public LogKind LogKind { get; }
		public MetaModelObject Target { get; }
		// MAYBE: private AnalysisSession analysisSession;

		public AnalysisProgram()
		{
		}

		// TODO: Streaming API things for: adding examples (really again??), setting log kind, setting metamodelobject
		// THINK ABOUT: replace analysis session by this or keep separate? maybe only our specialities here and PROSE stuff still capsuled in AnalysisSession?

		// TODO: describe method that gives human-readable summary (short & long?)
		// TODO: apply method (instead of "generate program" method)
		// TODO: see whether PROSE Sessions can be usefully saved
	}
}
