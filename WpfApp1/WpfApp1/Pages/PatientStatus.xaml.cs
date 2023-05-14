using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WpfApp1.Archetypes.Patient;
using WpfApp1.Database;
using WpfApp1.page_Classes;

namespace WpfApp1.Pages;

public partial class PatientStatus : Page
{

    private MainWindowClass _mainWindowClass;
    public PatientStatus(MainWindowClass mainWindowClass)
    {
        _mainWindowClass = mainWindowClass;
        InitializeComponent();
    }
    

    private void ButtonBase_Save(object sender, RoutedEventArgs e)
    {
        List<TextBox> errors = new List<TextBox>();
        bool err = false;
        int amount = 0;
        if (string.IsNullOrWhiteSpace(Jmeno.Text))
        {
            err = true;
            errors.Add(Jmeno);
        }
        if (string.IsNullOrWhiteSpace(Prijemni.Text))
        {
            err = true;
            errors.Add(Prijemni);
        }
        if (string.IsNullOrWhiteSpace(Bydliste.Text))
        {
            err = true;
            errors.Add(Bydliste);
        }
        if (string.IsNullOrWhiteSpace(RCislo.Text))
        {
            err = true;
            errors.Add(RCislo);
        }
        if (string.IsNullOrWhiteSpace(Tel.Text))
        {
            err = true;
            errors.Add(Tel);
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

        Patient patient = new Patient(0, Jmeno.Text, Prijemni.Text, RCislo.Text, Bydliste.Text, Tel.Text);
        Prijemni.Text = null;
        Jmeno.Text = null;
        RCislo.Text = null;
        Bydliste.Text = null;
        Tel.Text = null;
        Connection connection = new Connection();
        connection.InsertSQL("insert into patient (pname, surname, rnum, telnum, place)" +
                             $"values ('{patient.GetName()}', '{patient.GetSurname()}', '{patient.GetRnum()}', '{patient.GetPhone()}', '{patient.GetPlace()}')");
        
        NavigationService.Navigate(null);
    }
}