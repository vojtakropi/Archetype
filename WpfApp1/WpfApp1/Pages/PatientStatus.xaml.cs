using System.Windows;
using System.Windows.Controls;
using WpfApp1.Archetypes.Patient;
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
        Patient patient = new Patient(Jmeno.Text, Prijemni.Text, int.Parse(RCislo.Text), Bydliste.Text, int.Parse(Tel.Text));
        _mainWindowClass.AddPatient(patient);
        Prijemni.Text = null;
        Jmeno.Text = null;
        RCislo.Text = null;
        Bydliste.Text = null;
        Tel.Text = null;
        NavigationService.Navigate(null);
    }
}