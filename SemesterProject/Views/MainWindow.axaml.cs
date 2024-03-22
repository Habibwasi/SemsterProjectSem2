using Avalonia;
using System;
using Avalonia.Media;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Diagnostics;
using Avalonia.Interactivity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace SemesterProject.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.AttachDevTools();
        }
        public void ShowMore(object sender, RoutedEventArgs args)
        {

        }

        public void ModifyProfitExpensesIncome(object sender, RoutedEventArgs args)
        {
            income.Text = "";
            expenses.Text = "";
            profit.Text = "";
        }
        public void OpenHeatDemand(object sender, RoutedEventArgs args)
        {
            var heatDemandWindow = new HeatDemandWindow();
            heatDemandWindow.Show();
        }

        public void ClickButton2(object sender, RoutedEventArgs args)
        {

        }
        public void ClickButton3(object sender, RoutedEventArgs args)
        {


        }
        public void ClickButton4(object sender, RoutedEventArgs args)
        {

        }
        public void ClickButton5(object sender, RoutedEventArgs args)
        {

        }
        public void ClickButton6(object sender, RoutedEventArgs args)
        {

        }
        public void ClickButton7(object sender, RoutedEventArgs args)
        {


        }
        public void ClickButton8(object sender, RoutedEventArgs args)
        {

        }
        public void ClickButton9(object sender, RoutedEventArgs args)
        {

        }
        public void ClickButton10(object sender, RoutedEventArgs args)
        {

        }
    }
}
