using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp1.Archetypes.Observatory;
using WpfApp1.Database;

namespace WpfApp1.Pages;

public partial class Bmi : Page
{

    private List<string> states = new ()
    {
        "podvýživa",
        "normální",
        "nadváha",
        "obézní"
    };

    private MainWindow _mainWindow;
    public Bmi(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
        foreach (var state in states)
        {
            interpret.Items.Add(state);
        }
    }

    
    

    private void ButtonBase_Save(object sender, RoutedEventArgs e)
    {
        List<TextBox> errors = new List<TextBox>();
        bool err = false;
        decimal bmi = 0;
       
        decimal.TryParse(this.bmi.Text, out bmi);
        if (bmi==0) {
            errors.Add(this.bmi);
            err = true;
        }
        if (string.IsNullOrWhiteSpace(interpret.Text))
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

        BMI_object bmiObject = new BMI_object(decimal.Parse(this.bmi.Text), interpret.Text, comment.Text, cofounding.Text);
        Connection connection = new Connection();
        connection.InsertSQL($"insert into bmi (bmi, interpret, comment, factors, patientID)" +
                             $" values ({bmiObject.GetBmi()}, '{bmiObject.GetInterpret()}', '{bmiObject.GetComment()}'," +
                             $" '{bmiObject.GetConfoundingF()}', {_mainWindow.GetPatient().GetId()})");
        NavigationService.Navigate(null);
    }
}