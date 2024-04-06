using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AssetManager.ViewModels;
using static AssetManager.AssetManager1;
using System.Linq;
using System;

namespace AssetManager.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(); // Set DataContext here
        }


        private DirectPropertyBase<ProductionUnit[]> nameof(ProductionUnit[] productionUnits)
        {
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
