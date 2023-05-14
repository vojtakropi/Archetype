using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp1.Archetypes.medication;
using WpfApp1.Database;

namespace WpfApp1.Pages;

public partial class Medication : Page
{

    private List<string> units = new()
    {
        "mililitr",
        "litr",
        "tabletka",
        "gram",
        "miligram",
        "injekce"
    };
    private MainWindow _mainWindow;
    public Medication(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
        foreach (var unitt in units)
        {
            unit.Items.Add(unitt);
        }
    }
    
    private void ButtonBase_Save(object sender, RoutedEventArgs e)
    {
        List<TextBox> errors = new List<TextBox>();
        bool err = false;
        decimal amount = 0;
        if (string.IsNullOrWhiteSpace(medication.Text))
        {
            err = true;
            errors.Add(medication);
        }
        if (string.IsNullOrWhiteSpace(insertion.Text))
        {
            err = true;
            errors.Add(insertion);
        }
        if (string.IsNullOrWhiteSpace(place.Text))
        {
            err = true;
            errors.Add(place);
        }

        decimal.TryParse(this.amount.Text, out amount);
        if (string.IsNullOrWhiteSpace(this.amount.Text) || amount == 0)
        {
            err = true;
            errors.Add(this.amount);
        }
        if (string.IsNullOrWhiteSpace(unit.Text))
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

        Medication_object medicationObject = new Medication_object(medication.Text, insertion.Text, place.Text,
            decimal.Parse(this.amount.Text), comment.Text, unit.Text);
        
        Connection connection = new Connection();
        connection.InsertSQL($"insert into medication (medicationname, insertion, insertplace, amount, unit, comment, patientID)," +
                             $"values ('{medicationObject.GetMedication()}', '{medicationObject.GetRoute()}', '{medicationObject.GetBodySite()}'," +
                             $"{medicationObject.GetAmount()}, '{medicationObject.GetUnit()}', '{medicationObject.GetComment()}', {_mainWindow.GetPatient().GetId()})");
        
        NavigationService.Navigate(null);

    }
}