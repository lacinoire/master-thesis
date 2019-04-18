using System;

namespace pbeextractionbuildlogs
{
	public class ConsoleInteraction
	{
		private struct Choice
		{
			public string identifier;
			public string description;
			public Action action;

			public Choice(string identifier, string description, Action action)
			{
				this.identifier = identifier;
				this.description = description;
				this.action = action;
			}
		}

		public static void Run()
		{
			Console.WriteLine("Welcome to the buildlog analyzer! We make parsing bulidlogs fun with examples \U0001F389");

			AnalysisSession analysisSession = new AnalysisSession();

			while (true)
			{
				GiveChoice("Would you like me to",
					new Choice("e", "\u2795 Add a new example or", () => AddInput(analysisSession)),
					new Choice("a", "\U0001F50D Analyze a file with current exampleset or", () => RunOnTestInput(analysisSession)),
					new Choice("p", "\U0001F5A8 Print the current program or", () => PrintCurrentProgram(analysisSession)),
					new Choice("s", "\U0001F4C1 Save the current exampleset or", () => SaveProgram(analysisSession)),
					new Choice("l", "\U0001F4C2 Load a saved exampleset or", () => analysisSession = LoadProgram(analysisSession)),
					new Choice("r", "\U0001F5D1 Reset the current exampleset?", () => PrintCurrentProgram(analysisSession)));
			}
		}

		private static void AddInput(AnalysisSession analysisSession)
		{
			var inputPath = RequestBuildlogFilePath();
			analysisSession.AddInput(inputPath);

			Console.WriteLine("\U0001F64C Thank you! I added the file to the list of example inputs.");

			GiveChoice("Would you like to make a complete example out of it by providing the file content interesting for you?   \U0001F647",
				new Choice("y", "\u2705 Yes!", () =>
				{
					Console.WriteLine("Please tell me, what part from that file was interesting? \U0001F50E (in one line, you might need to escape stuff!)");
					analysisSession.AddExample(inputPath, Console.ReadLine());
					Console.WriteLine("\U0001F44D Thank you! I added the new example.");
				}),
				new Choice("n", "\U0001F645 No.", () => { }));
		}

		private static void RunOnTestInput(AnalysisSession analysisSession)
		{
			var inputPath = RequestBuildlogFilePath();
			var output = analysisSession.Analyze(inputPath);
			if (output == null)
			{
				Console.WriteLine("\U0001F614 Sadly we found noting in this file using the current exampleset.");
			}
			else
			{
				Console.WriteLine("\U0001F913 I have found the following relvant parts in your bulidlog:");
				Console.WriteLine(output);
			}
		}

		private static void PrintCurrentProgram(AnalysisSession analysisSession)
		{
			Console.WriteLine("\U0001F4C3 This is the programm generated for all the examples that I currently have:");
			Console.WriteLine(analysisSession.CurrentProgram());
		}

		private static void SaveProgram(AnalysisSession analysisSession)
		{
			Console.WriteLine("Under which name would you like to save the exampleset? \U0001F914");
			var name = Console.ReadLine();
			analysisSession.Save(name);
		}

		private static AnalysisSession LoadProgram(AnalysisSession analysisSession)
		{
			Console.Write("What is the name of the exampleset you would like to load? \U0001F9D0\n");
			return AnalysisSession.Load(Console.ReadLine());
		}

		private static void GiveChoice(string intro, params Choice[] choices)
		{
			Boolean repeatChoice = true;
			if (repeatChoice)
			{
				Console.WriteLine(intro);
				foreach (Choice c in choices)
				{
					Console.WriteLine("(" + c.identifier + ") " + c.description);
				}
				var answer = Console.ReadLine();
				foreach (Choice c in choices)
				{
					if (answer == c.identifier)
					{
						c.action();
						repeatChoice = false;
						break;
					}
				}
			}
		}

		private static string RequestBuildlogFilePath()
		{
			Console.WriteLine("Please provide the path \U0001F6B6 to your buildlog-file, starting from inside the \"samples\" folder:");
			return Console.ReadLine();
		}
	}
}
