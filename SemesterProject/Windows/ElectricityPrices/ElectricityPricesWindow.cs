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

    public partial class ElectriciyPricesWindow : Window
    {
        public ElectriciyPricesWindow()
        {
            InitializeComponent();
            this.AttachDevTools();
        }
    }
}