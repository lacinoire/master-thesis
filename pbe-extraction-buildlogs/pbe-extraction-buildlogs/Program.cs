using System;
using System.IO;
using Microsoft.ProgramSynthesis.DslLibrary;
using Microsoft.ProgramSynthesis.Extraction.Text;
using Microsoft.ProgramSynthesis.Extraction.Text.Constraints;

namespace pbeextractionbuildlogs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the buildlog analyzer! We make parsing bulidlogs fun with Examples \U0001F389");
            RegionSession session = new RegionSession();

            while (true)
            {
                Console.Write("Would you like me to\n" +
                    "(e) Add a new example or\n" +
                    "(a) Analyze a file with the current exampleset or\n" +
                    "(p) Print the current program or\n" +
                    "(r) Reset the current exampleset?\n");
                var answer = Console.ReadLine();
                switch (answer)
                {
                    case "e":
                        AddInput(session);
                        break;
                    case "a":
                        RunOnTestInput(session);
                        break;
                    case "p":
                        PrintCurrentProgram(session);
                        break;
                    case "r":
                        session = new RegionSession();
                        break;
                }
            }
        }

        private static void AddInput(RegionSession session)
        {
            var logfileText = RequestFileFromUser();
            session.Inputs.Add(new[] { logfileText });

            Console.WriteLine("Thank you! I added the file to the list of example inputs.");
            Console.WriteLine("Would you like to make a complete example out of it by providing the filecontent interesting for you?\n" +
                "(y) Yes\n(n) No");
            var answer = Console.ReadLine();
            if (answer == "n")
            {
                return;
            }

            Console.WriteLine("Please tell me, what part from that file was interesting? (in one line, you might need to escape stuff!)");
            var desiredExtraction = Console.ReadLine();

            var startIndex = logfileText.S.IndexOf(desiredExtraction, StringComparison.Ordinal);

            var desiredExtractionRegion = logfileText.Slice((uint)startIndex, (uint)(startIndex + desiredExtraction.Length));

            session.Constraints.Add(new RegionExample(logfileText, desiredExtractionRegion));
            Console.WriteLine("Thank you! I added the new example.");
        }

        private static void RunOnTestInput(RegionSession session)
        {
            // TODO check that we actually have examples?
            var fileToAnalyze = RequestFileFromUser();

            RegionProgram topRankedProg = session.Learn();
            StringRegion output = topRankedProg.Run(fileToAnalyze);

            Console.WriteLine("I have found the following relvant parts in your bulidlog:");
            Console.WriteLine(output);
        }

        private static void PrintCurrentProgram(RegionSession session)
        {
            Console.WriteLine("This is the programm generated for all the examples that I currently have:");

            RegionProgram topRankedProgram = session.Learn();

            Console.Write(topRankedProgram.Serialize());
        }

        private static StringRegion RequestFileFromUser()
        {
            Console.WriteLine("Please provide the path to your buildlog-file, starting from inside the \"samples\" folder:");
            var path = Console.ReadLine();
            string logfileText = File.ReadAllText("../../../samples/" + path);
            return RegionSession.CreateStringRegion(logfileText);
        }
    }
}
