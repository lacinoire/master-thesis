using System;
namespace pbeextractionbuildlogs
{
	public class Config
	{
		//public static string ROOT_DIRECTORY = "../../../";
		public static string ROOT_DIRECTORY = "../";
		public static string PROGRAM_DATA_DIRECTORY = ROOT_DIRECTORY +
			"tool/example-sets/";
		public static string SAMPLE_DIRECTORY = ROOT_DIRECTORY + "tool/samples/";
		public static string RESULT_DIRECTORY = ROOT_DIRECTORY + "evaluation/results/pbe/";

		public static string LOG_KIND_FILE_PATH = ROOT_DIRECTORY + "pbe-extraction-buildlogs/ressources/log-kinds.txt";
	}
}
