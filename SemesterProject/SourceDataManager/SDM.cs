using System;
using System.IO;
using Avalonia.Controls;
using Avalonia.Logging;
using System.Diagnostics;
using Avalonia.Media;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia;

namespace SemesterProject.Views
{
    public class SourceDataManager
    {
        public static void CSVContentRead(string filePath)
        {
            // Read from the CSV file
            string[][] data = 
            [
                [""],//left empty for new row to be placed
                ["2/14/2023 2:00,2/14/2023 3:00,6.32,984.39,,7/14/2023 2:00,7/14/2023 3:00,1.66,634.13    NEWLINE"],
                ["2/14/2023 23:00,2/15/2023 0:00,6.35,1055.68,,7/14/2023 23:00,7/15/2023 0:00,1.62,607.05 NEWLINE"]
            ];
            using (StreamReader reader = new StreamReader(filePath))
            {
                string[] lines = reader.ReadToEnd().Split(Environment.NewLine);
                data = new string[lines.Length][];
                for (int i = 0; i < lines.Length; i++)
                {
                    data[i] = lines[i].Split(",");
                }
            }
            //string[] lines = File.ReadAllLines(filePath);
            var csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), "SourceDataManager\\newfile.csv");
            AppendToCSV(csvFilePath, data);
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
