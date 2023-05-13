using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Pages;

public partial class Bmi : Page
{

    private List<string> states;
    public Bmi()
    {
        InitializeComponent();
        states = new List<string> { "podvýživa", "normální", "nadváha", "obézní" };
        foreach (var state in states)
        {
            interpret.Items.Add(state);
        }
    }

    
    

    private void ButtonBase_Save(object sender, RoutedEventArgs e)
    {
        var t = "";
    }
}