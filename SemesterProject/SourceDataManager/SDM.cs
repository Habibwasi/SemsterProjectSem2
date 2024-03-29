using System;
using System.IO;
using Avalonia.Logging;
using System.Diagnostics;
namespace SemesterProject.Views
{
    public class SourceDataManager
    {
        public static void CSVContentRead(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            string[][] data =
            [
                ["01/02/2004","20:00"],
                ["01/04/2004","22:00"]
            ];
            WriteToCSV(filePath,data);
        }
        /*
        ****************DATA EXAMPLE**************
        string[][] data = new string[][]
        {
            new string[] {"01/02/2004","20:00"};
            new string[] {"01/04/2004","22:00"};
        };
        */
        public static void WriteToCSV(string filePath, string[][] data)
        {
            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string[] line in data)
                {
                    writer.WriteLine(string.Join(",",line));
                }//works but deletes all the data from file and replaces it with the new data from input
            }
        }
    }
}