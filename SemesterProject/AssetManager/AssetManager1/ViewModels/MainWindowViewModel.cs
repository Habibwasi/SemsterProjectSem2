using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using AssetManager;

namespace AssetManager.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<string> ProductionUnits { get; set; }

        public MainWindowViewModel()
        {
            PopulateProductionUnits();
        }

        private void PopulateProductionUnits()
        {
            ProductionUnits = AssetManager1.ProductionUnits.Select(unit =>
                $"Name: {unit.Name}, MaxHeat: {unit.MaxHeat}, MaxElectricity: {unit.MaxElectricity}, ProductionCosts: {unit.ProductionCosts}, CO2Emissions: {unit.CO2Emissions}, FuelType: {unit.FuelType}"
            ).ToList();
        }
    }
}
