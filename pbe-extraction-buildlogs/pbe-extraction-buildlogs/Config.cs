using System;
namespace pbeextractionbuildlogs
{
	public class Config
	{
		//public static string ROOT_DIRECTORY = "../../../";
		public static string ROOT_DIRECTORY = "";
		public static string PROGRAM_DATA_DIRECTORY = ROOT_DIRECTORY +
			"ressources/analysis-programs/";
		public static string SAMPLE_DIRECTORY = ROOT_DIRECTORY + "samples/";

		public static string LOG_KIND_FILE_PATH = ROOT_DIRECTORY + "ressources/log-kinds.txt";
	}
}
