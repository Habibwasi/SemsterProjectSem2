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
            string[][] data =
            [
                ["01/02/2004","20:00"],
                ["6/12/9696 23:00,6/12/9696 0:00,6.35,1055.68,,7/14/2023 23:00,7/15/2023 0:00,1.62,607.05"]
            ];
            AppendToCSV(filePath, data);
        }
        public static void AppendToCSV(string filePath, string[][] data)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true)) // Pass 'true' to append
            {
                foreach (string[] line in data)
                {
                    writer.WriteLine(string.Join(",", line));
                }
            }
        }

    }
}