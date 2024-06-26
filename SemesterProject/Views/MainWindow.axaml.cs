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
        public void OpenCO2Emmisions(object sender, RoutedEventArgs args)
        {
            var cO2EmmisionsWindow = new CO2EmmisionWindow();
            cO2EmmisionsWindow.Show();
        }
        public void OpenConsumption(object sender, RoutedEventArgs args)
        {
            var consumptionWindow = new ConsumptionWindow();
            consumptionWindow.Show();
        }
        public void OpenConsumptionOfPrimaryEnergy(object sender, RoutedEventArgs args)
        {
            var consumptionOfPrimaryEnergyWindow = new ConsumptionOfPrimaryEnergyWindow();
            consumptionOfPrimaryEnergyWindow.Show();
        }
        public void OpenElectricityPrices(object sender, RoutedEventArgs args)
        {
            var electricityPricesWindow = new ElectriciyPricesWindow();
            electricityPricesWindow.Show();
        }
        public void OpenExpensesAndProfit(object sender, RoutedEventArgs args)
        {
            var expensesAndProfitWindow = new ExpensesAndProfitWindow();
            expensesAndProfitWindow.Show();
        }
        public void OpenHeatDemand(object sender, RoutedEventArgs args)
        {
            var heatDemandWindow = new HeatDemandWindow();
            heatDemandWindow.Show();
        }

        public void OpenHeatProduction(object sender, RoutedEventArgs args)
        {
            var heatProductionWindow = new HeatProductionWindow();
            heatProductionWindow.Show();
        }
        public void OpenPrioritiesOfProductionUnits(object sender, RoutedEventArgs args)
        {
            var prioritiesOfProductionUnitsWindow = new PrioritiesOfProductionUnitsWindow();
            prioritiesOfProductionUnitsWindow.Show();
        }

        public void OpenProductionUits(object sender, RoutedEventArgs args)
        {
            var productionUitsWindow = new ProductionUnitsWindow();
            productionUitsWindow.Show();
        }
        public void OpenProductionValues(object sender, RoutedEventArgs args)
        {
            var productionValuesWindow = new ProductionValuesWindow();
            productionValuesWindow.Show();
        }

    }
}
