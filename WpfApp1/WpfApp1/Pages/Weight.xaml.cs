using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Pages;

public partial class Weight : Page
{

    private List<string> _clothesstate = new()
    {
        "nahatý",
        "lehce oblečen/spodní prádlo",
        "oblečen/bez bot",
        "oblečen/s botami"

    };
    public Weight()
    {
        InitializeComponent();
        foreach (var state in _clothesstate)
        {
            stateofclotsh.Items.Add(state);
        }
    }
    
    private void ButtonBase_Save(object sender, RoutedEventArgs e)
    {
        var t = "";
    }
}