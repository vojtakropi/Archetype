using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp1.Archetypes.Evaulation;
using WpfApp1.Archetypes.Observatory;
using WpfApp1.Database;

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
        List<TextBox> errors = new List<TextBox>();
        bool err = false;
        int systolic = 0;
        int diastolic = 0;
        int pulsing = 0;
        decimal arterial = 0;

        int.TryParse(sys.Text, out systolic);
        int.TryParse(dia.Text, out diastolic);
        int.TryParse(puls.Text, out pulsing);
        decimal.TryParse(art.Text, out arterial);
        
        if (string.IsNullOrWhiteSpace(pos.Text))
        {
            err = true;
        }
        if (string.IsNullOrWhiteSpace(sleep.Text))
        {
            err = true;
        }
        if (systolic == 0)
        {
            err = true;
            errors.Add(sys);
        }
        if (diastolic == 0)
        {
            err = true;
            errors.Add(dia);
        }
        if (pulsing == 0)
        {
            err = true;
            errors.Add(puls);
        }
        if (arterial == 0)
        {
            err = true;
            errors.Add(art);
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

        BloodPressure_object bloodPressureObject = new BloodPressure_object(int.Parse(sys.Text), int.Parse(dia.Text), int.Parse(puls.Text),
            decimal.Parse(art.Text), pos.Text, sleep.Text, comment.Text);
        
        Connection connection = new Connection();
        connection.InsertSQL($"insert into blood_pressure (systolic, dyastolic, puls, arterial_mean, position, sleep_status, comment, PatientID) " +
                             $"values ({bloodPressureObject.GetSystolic()}, {bloodPressureObject.GetDiastolic()}, {bloodPressureObject.GetPulse()}, " +
                             $"{bloodPressureObject.GetMeanArterieal()}, '{bloodPressureObject.GetPosition()}', '{bloodPressureObject.GetSleepStatus()}'," +
                             $" '{bloodPressureObject.GetComment()}',  {_mainWindow.GetPatient().GetId()})");
        
        Connection newcon = new Connection();
        List<Tuple<DateTime, string>> visits; 
        newcon.GetVisits(_mainWindow.GetPatient().GetId(), out visits);
        _mainWindow.AddButtons(visits);
        NavigationService.Navigate(null);
    }
}