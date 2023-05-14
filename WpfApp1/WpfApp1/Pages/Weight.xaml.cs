using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp1.Archetypes.Observatory;
using WpfApp1.Database;

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
    private MainWindow _mainWindow;
    public Weight(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
        foreach (var state in _clothesstate)
        {
            stateofclotsh.Items.Add(state);
        }
    }
    
    private void ButtonBase_Save(object sender, RoutedEventArgs e)
    {
        List<TextBox> errors = new List<TextBox>();
        bool err = false;
        decimal weights = 0;
       
        decimal.TryParse(weight.Text, out weights);
        if (weights==0) {
            errors.Add(weight);
            err = true;
        }
        if (string.IsNullOrWhiteSpace(stateofclotsh.Text))
        {
            err = true;
        }
        
        if (err)
        {
            var converter = new BrushConverter();
            foreach (var error in errors)
            {
                // ReSharper disable once AssignNullToNotNullAttribute
                error.Background = (Brush)converter.ConvertFromString("#f44336");
            }
            return;
        }

        Weight_object weightObject = new Weight_object(decimal.Parse(weight.Text), comment.Text, stateofclotsh.Text, cofounding.Text);
        Connection connection = new Connection();
        connection.InsertSQL($"insert into weight (weights, comment, clothes, cofounding, patientID)" +
                           $" values ({weightObject.GetWeight()}, '{weightObject.GetComment()}', '{weightObject.GetStateOfD()}'," +
                           $" '{weightObject.GetCofoundingF()}', {_mainWindow.GetPatient().GetId()})");
        NavigationService.Navigate(null);
        
    }
}