using System;
using System.Collections.Generic;

namespace pbeextractionbuildlogs
{
	/// <summary>
	/// Holds all the different programs this tool learnt for extracting information.
	/// </summary>
	public class ProgramCollection
	{
		public List<AnalysisProgram> AnalysisPrograms = new List<AnalysisProgram>();

		public AnalysisProgram AddTravisWorkerProgram()
		{
			AnalysisProgram program = new AnalysisProgram("travis-worker", new LogKind("all", "all"), MetaModelObject.TravisWorker, takeFromFileIfPossible: true);
			program
				.AddExample("AdRoll@hologram/1_53661720_bcfe34b206aa75df8a1f6bee9153190bfcc6ca4b_53661722.log", "worker-linux-c55820f2-2.bb.travis-ci.org:travis-linux-11")
				.AddExample("AdRoll@hologram/3_53664779_e1988cc65bbe55e7930f29b4f5bed04af363dfcc_53664780.log", "worker-linux-c55820f2-1.bb.travis-ci.org:travis-linux-3")
				.AddExample("ant0ine@go-json-rest/1_5093969_e309d425737489de58a7a765aece0275f85cbb21_5093970.log", "ruby6.worker.travis-ci.org:travis-ruby-3");
			program.Save();
			return program;
		}
		// TODO: methods to fill with useful programs. Start with one for the TravisWorker
	}
}
