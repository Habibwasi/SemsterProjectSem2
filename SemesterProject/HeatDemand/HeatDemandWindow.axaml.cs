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

    public partial class HeatDemandWindow : Window
    {
        public HeatDemandWindow()
        {
            InitializeComponent();
            this.AttachDevTools();
        }
    }
}