using System;
using Avalonia;
using System.IO;
using Avalonia.Media;
using Avalonia.Logging;
using Avalonia.Controls;
using System.Diagnostics;
using Avalonia.Markup.Xaml;
using Avalonia.Diagnostics;
using Avalonia.Interactivity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace SemesterProject.Views
{

    public partial class HeatDemandWindow : Window
    {
        public HeatDemandWindow()
        {
            InitializeComponent();
            this.AttachDevTools();
        }

        public void DisplayCSVContent()
        {
            string csvFilePath = "C:\\Users\\asus\\OneDrive\\Desktop\\carti\\Sem2\\SP\\SemesterProjectSem2\\SemesterProject\\SourceDataManager\\data.csv";
            SourceDataManager.CSVContentRead(csvFilePath);
        }


        public void HourButtonCommand(object sender, RoutedEventArgs args)
        {
            if (HourButton.IsChecked == true)
            {
                //HourGraph display
                DisplayCSVContent();
                DayButton.IsChecked = false; WeekButton.IsChecked = false; MonthButton.IsChecked = false; YearButton.IsChecked = false; MaxButton.IsChecked = false;
            }
        }
        public void DayButtonCommand(object sender, RoutedEventArgs args)
        {
            if (DayButton.IsChecked == true)
            {
                //DayGraph display
                HourButton.IsChecked = false; WeekButton.IsChecked = false; MonthButton.IsChecked = false; YearButton.IsChecked = false; MaxButton.IsChecked = false;
            }

        }
        public void WeekButtonCommand(object sender, RoutedEventArgs args)
        {
            if (WeekButton.IsChecked == true)
            {
                //WeekGraph display
                HourButton.IsChecked = false; DayButton.IsChecked = false; MonthButton.IsChecked = false; YearButton.IsChecked = false; MaxButton.IsChecked = false;
            }
        }
        public void MonthButtonCommand(object sender, RoutedEventArgs args)
        {
            if (MonthButton.IsChecked == true)
            {
                //MonthGraph display
                HourButton.IsChecked = false; DayButton.IsChecked = false; WeekButton.IsChecked = false; YearButton.IsChecked = false; MaxButton.IsChecked = false;
            }
        }
        public void YearButtonCommand(object sender, RoutedEventArgs args)
        {
            if (YearButton.IsChecked == true)
            {
                //YearGraph display
                HourButton.IsChecked = false; DayButton.IsChecked = false; WeekButton.IsChecked = false; MonthButton.IsChecked = false; MaxButton.IsChecked = false;
            }
        }
        public void MaxButtonCommand(object sender, RoutedEventArgs args)
        {

            if (MaxButton.IsChecked == true)
            {
                //MaxGraph display
                HourButton.IsChecked = false; DayButton.IsChecked = false; WeekButton.IsChecked = false; MonthButton.IsChecked = false; YearButton.IsChecked = false;
            }
        }
    }
}