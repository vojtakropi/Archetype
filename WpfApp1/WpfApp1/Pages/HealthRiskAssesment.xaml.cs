using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp1.Archetypes.Evaulation;
using WpfApp1.Archetypes.medication;
using WpfApp1.Database;

namespace WpfApp1.Pages;

public partial class HealthRiskAssesment : Page
{
    
    private MainWindow _mainWindow;

    private List<string> _present = new()
    {
        "přítomný",
        "nepřítomný",
        "nelze určit"
    };
    public HealthRiskAssesment(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
        foreach (var state in _present)
        {
            isin.Items.Add(state);
        }
    }
    
    
    private void ButtonBase_Save(object sender, RoutedEventArgs e)
    {
        List<TextBox> errors = new List<TextBox>();
        bool err = false;
        decimal amount = 0;
        if (string.IsNullOrWhiteSpace(risk.Text))
        {
            err = true;
            errors.Add(risk);
        }
        if (string.IsNullOrWhiteSpace(namerisk.Text))
        {
            err = true;
            errors.Add(namerisk);
        }
        if (string.IsNullOrWhiteSpace(isin.Text))
        {
            err = true;
        }
        if (string.IsNullOrWhiteSpace(methode.Text))
        {
            err = true;
            errors.Add(methode);
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

        HealtRiskAssessment_object healtRiskAssessment = new HealtRiskAssessment_object(risk.Text, namerisk.Text, isin.Text, 
            methode.Text, comment.Text);
        
        Connection connection = new Connection();
        connection.InsertSQL($"insert into health_risk_assesment (health_risk, risk_factor, present, method, comment, patientID) " +
                             $"values ('{healtRiskAssessment.GethealthRisk()}', '{healtRiskAssessment.GetDescription()}', '{healtRiskAssessment.GetPresenece()}'," +
                             $" '{healtRiskAssessment.GetAssesmentMethode()}', '{healtRiskAssessment.GetComment()}', {_mainWindow.GetPatient().GetId()})");
        Connection newcon = new Connection();
        List<Tuple<DateTime, string>> visits; 
        newcon.GetVisits(_mainWindow.GetPatient().GetId(), out visits);
        _mainWindow.AddButtons(visits);
        NavigationService.Navigate(null);

    }
}
