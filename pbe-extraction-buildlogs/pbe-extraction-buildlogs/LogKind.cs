using System;
using System.Collections.Generic;

namespace pbeextractionbuildlogs
{
	/// <summary>
	/// Represents the code language / buildtool combination which generated a buildlog. Used to select the adequate AnalysisProgram.
	/// </summary>
	public class LogKind
	{
		public string Language { get; }
		public string BuildTool { get; }

		public LogKind(string language, string buildtool)
		{
			Language = language;
			BuildTool = buildtool;
		}

		public static List<LogKind> GetAllLogKinds()
		{
			throw new NotImplementedException();
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
