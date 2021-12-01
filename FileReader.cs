using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShakespeareHelpfulInsultsTexts
{
    public static class FileReader
    {
        //need to read file to end and return a list
         public static List<string> ReadFileToList(string filePath)
          {
            List<string> returnList = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        returnList.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: fix non DRY
                Console.WriteLine(ex.Message);
            }
            return returnList;
        }

        public static void WriteToFile(string filePath, string insult)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(insult);
                }
 
            }
            catch (Exception ex)
            {
                //TODO: fix non DRY
                Console.WriteLine(ex.Message);
            }
        }
    }



}
