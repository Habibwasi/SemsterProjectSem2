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
        private Window _previousWindow;
        public void DisplayCSVContent()
        {
            var csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), "SourceDataManager\\data.csv");
            SourceDataManager.CSVContentRead(csvFilePath);
        }
        private void ClosePreviousWindow()
        {
           if(_previousWindow !=null)
           {
            _previousWindow.Close();
           }
        }


        public void HourButtonCommand(object sender, RoutedEventArgs args)
        {
            if (HourButton.IsChecked == true)
            {
                ClosePreviousWindow();
                //HourGraph display
                DisplayCSVContent();
                DayButton.IsChecked = false; WeekButton.IsChecked = false; MonthButton.IsChecked = false;   MaxButton.IsChecked = false;
                _previousWindow = this;
            }
        }
        public void DayButtonCommand(object sender, RoutedEventArgs args)
        {
            if (DayButton.IsChecked == true)
            {
                ClosePreviousWindow();
                //DayGraph display
                DisplayCSVContent();
                HourButton.IsChecked = false; WeekButton.IsChecked = false; MonthButton.IsChecked = false;   MaxButton.IsChecked = false;
                _previousWindow = this; 
            }

        }
        public void WeekButtonCommand(object sender, RoutedEventArgs args)
        {
            if (WeekButton.IsChecked == true)
            {
                ClosePreviousWindow();
                //WeekGraph display
                DisplayCSVContent();
                HourButton.IsChecked = false; DayButton.IsChecked = false; MonthButton.IsChecked = false;   MaxButton.IsChecked = false;
                _previousWindow = this;
            }
        }
        public void MonthButtonCommand(object sender, RoutedEventArgs args)
        {
            if (MonthButton.IsChecked == true)
            {
                ClosePreviousWindow();
                //MonthGraph display
                DisplayCSVContent();
                HourButton.IsChecked = false; DayButton.IsChecked = false; WeekButton.IsChecked = false;   MaxButton.IsChecked = false;
                _previousWindow = this;
            }
        }
        public void MaxButtonCommand(object sender, RoutedEventArgs args)
        {

            if (MaxButton.IsChecked == true)
            {
                ClosePreviousWindow();
                //MaxGraph display
                DisplayCSVContent();
                HourButton.IsChecked = false; DayButton.IsChecked = false; WeekButton.IsChecked = false; MonthButton.IsChecked = false;  
                _previousWindow = this;
            }
        }
    }
}