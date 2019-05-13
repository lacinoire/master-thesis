using System;
using System.Collections.Generic;
using System.IO;

namespace pbeextractionbuildlogs
{
	/// <summary>
	/// Represents the code language / buildtool combination which generated a buildlog. Used to select the adequate AnalysisProgram.
	/// </summary>
	public class LogKind
	{
		public string Language { get; }
		public string BuildTool { get; }

		public LogKind(string language, string buildTool)
		{
			Language = language;
			BuildTool = buildTool;
		}

		public static List<LogKind> GetAllLogKinds()
		{
			string[] fileLines = File.ReadAllLines(Config.LOG_KIND_FILE_PATH);
			List<LogKind> logKinds = new List<LogKind>();
			foreach (string line in fileLines)
			{
				string[] data = line.Split('/');
				logKinds.Add(new LogKind(data[0], data[1]));

			}
			return logKinds;
			// TODO: parse all from a file defined in config
		}

		public static void SaveLogKind(LogKind logKind)
		{
			throw new NotImplementedException();
			// TODO: append to log kind file a new line with this kind
			// return newly created kind
		}
	}
}
