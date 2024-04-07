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
            string[][] data;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string[] lines = reader.ReadToEnd().Split(Environment.NewLine);
                data = new string[lines.Length][];
                for (int i = 0; i < lines.Length; i++)
                {
                    data[i] = lines[i].Split(",");
                }
            }

            // Extract and display specific columns from the data
            DisplaySelectedColumns(data, new int[] { 0, 1, 5, 6 });
        }

        private static void DisplaySelectedColumns(string[][] data, int[] columns)
        {
            if (Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                // Create a ListBox to display the data
                ListBox listBox = new ListBox();

                // Add selected columns from each row of data to the ListBox
                foreach (string[] row in data)
                {
                    string rowData = "";
                    foreach (int column in columns)
                    {
                        if (column >= 0 && column < row.Length)
                        {
                            rowData += row[column] + ", ";
                        }
                    }

                    TextBlock textBlock = new TextBlock();
                    textBlock.Text = rowData.TrimEnd(',', ' '); // Trim the trailing comma and space
                    textBlock.Foreground = Brushes.Black; // Set text color

                    listBox.Items.Add(textBlock);
                }

                // Create a window to host the ListBox
                Window window = new Window();
                window.Width = 400;
                window.Height = 300;
                window.Content = listBox;

                // Show the window
                desktop.MainWindow = window;
                desktop.MainWindow.Show();
            }
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
