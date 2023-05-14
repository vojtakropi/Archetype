using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Pages;

public partial class BloodPressure : Page
{
    private readonly List<string> _positions = new()
    {
        "stojící",
        "sedící",
        "ležící",
        "ležící s náklonem doleva"
    };
    private readonly List<string> _sleepstat = new()
    {
        "spící",
        "vzhůru"
    };
    private MainWindow _mainWindow;
    public BloodPressure(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
        foreach (var sleeps in _sleepstat)
        {
            sleep.Items.Add(sleeps);
        }

        foreach (var position in _positions)
        {
            pos.Items.Add(position);
        }
        
    }
    
    
    private void ButtonBase_Save(object sender, RoutedEventArgs e)
    {
        var t = "";
    }
}