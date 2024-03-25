using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaApplication2.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AvaloniaApplication2;

public partial class Page2 : UserControl
{
    public ObservableCollection<User> users { get; set; }
    public Page2()
    {
        InitializeComponent();
        users = new ObservableCollection<User>()
        {
            new User(15,"Aidar"),
            new User(18,"Arseniy")
        };

        DataContext = this;
   
    }
}