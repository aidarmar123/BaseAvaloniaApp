using Avalonia.Controls;
using AvaloniaApplication2.Models;
using System.Collections.ObjectModel;

namespace AvaloniaApplication2
{
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            App.mainWindow = this;
        }

        private void Page1_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            CCMainFrame.Content = new UserControl1();
        }

        private void Page2_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            CCMainFrame.Content = new Page2();
        }

        
    }
}