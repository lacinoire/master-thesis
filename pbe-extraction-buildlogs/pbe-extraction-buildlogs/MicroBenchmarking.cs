using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace pbeextractionbuildlogs
{
	[SimpleJob(RunStrategy.Monitoring, launchCount: 1, warmupCount: 1, targetCount: 3)]
	[MinColumn, MaxColumn, MeanColumn, MedianColumn]
	public class MicroBenchmarking
	{

		private static readonly string SAMPLE_PATH = "../../../benchmark-data/connectbot/";
		//private static readonly int UPPER_BOUND_CONNECTBOT = 10;//977;

		[Params(10, 100, 500, 977)]
		public int UPPER_BOUND_CONNECTBOT { get; set; }

		[Benchmark]
		public void BenchmarkConnectbot()
		{
			AnalysisSession analysisSession = new AnalysisSession();

			analysisSession
				.AddExample(SAMPLE_PATH + "c1.log", "travis_time:start:0479293b")
				.AddExample(SAMPLE_PATH + "c2.log", "travis_time:start:06da2ef0");
			//.AddExample(SAMPLE_PATH + "c3.log", ",finish=1413673465672132356,duration=6617901432")
			//.AddExample(SAMPLE_PATH + "c4.log", ",finish=1413674413184895928,duration=6647705086")
			//.AddExample(SAMPLE_PATH + "c5.log", "time:end:03f6dbfc:start=1413675524121062671,finish=1413675531309085970")
			//.AddExample(SAMPLE_PATH + "c6.log", ",finish=1413676785357984263,duration=5181447792")
			//.AddExample(SAMPLE_PATH + "c7.log", "time:end:13a98b89:start=1413677011417999249,finish=1413677019320470125");

			Console.WriteLine("\n" + analysisSession.CurrentProgram() + "\n");

			for (int i = 1; i < UPPER_BOUND_CONNECTBOT; i++)
			{
				var output = analysisSession.Analyze(SAMPLE_PATH + "c" + i + ".log");
				Console.WriteLine(i + " / " + UPPER_BOUND_CONNECTBOT + ": " + output);
			}
		}
	}
}
