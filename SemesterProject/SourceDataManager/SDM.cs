using System;
using System.IO;

namespace SemesterProject.Views
{
    public class SourceDataManager
    {
        public static void CSVContent(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}