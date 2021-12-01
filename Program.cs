using System;
using System.IO;
using System.Collections.Generic;

namespace ShakespeareHelpfulInsultsTexts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //ask user for number of insults to generate
            //donehow to get the text into the app
            //doneload texts into memory
            // pick random words from each
            //write insult to a file
            //in the context of the .exe
            string directory = Environment.CurrentDirectory;

            string insultsFile = "Insults.txt";
            string additionalInsultsFile = "AdditionalInsults.txt";
            string nounsFile = "Nouns.txt";

            //FileReader fr = new FileReader();//doesnt work because static
            List<string> insults = FileReader.ReadFileToList(Path.Combine(directory, insultsFile));
            List<string> additionalInsults = FileReader.ReadFileToList(Path.Combine(directory, additionalInsultsFile));
            List<string> nouns = FileReader.ReadFileToList(Path.Combine(directory, nounsFile));

            string firstInsult = GetRandomValueFromList(insults);
            string additionalInsult = GetRandomValueFromList(additionalInsults);
            string noun = GetRandomValueFromList(nouns);

            //Console.WriteLine($"Thou {firstInsult} {additionalInsult} {noun}");
            string insult = $"Thou {firstInsult} {additionalInsult} {noun}";

            string outputFile = "full-insults.txt";

            FileReader.WriteToFile(Path.Combine(directory, outputFile), insult);

        }

        public static string GetRandomValueFromList(List<string> list)
        {
            string output = "";
            Random rnd = new Random();
            int choosenIndex = rnd.Next(0, list.Count);

            output = list[choosenIndex];
            return output;
        }
    }
}
