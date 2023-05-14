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
    public HealthRiskAssesment(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
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

        if (date.SelectedDate == null)
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

        HealtRiskAssessment_object healtRiskAssessment = new HealtRiskAssessment_object(risk.Text, namerisk.Text, isin.Text,
            date.SelectedDate, methode.Text, comment.Text);
        
        Connection connection = new Connection();
        connection.InsertSQL($"insert into medication (health_risk, risk_factor, present, date_of_find, method, comment, patientID)," +
                             $"values ('{healtRiskAssessment.GethealthRisk()}', '{healtRiskAssessment.GetDescription()}', '{healtRiskAssessment.GetPresenece()}'," +
                             $"'{healtRiskAssessment.GetDate()}', '{healtRiskAssessment.GetAssesmentMethode()}', '{healtRiskAssessment.GetComment()}', {_mainWindow.GetPatient().GetId()})");
        
        NavigationService.Navigate(null);

    }
}
