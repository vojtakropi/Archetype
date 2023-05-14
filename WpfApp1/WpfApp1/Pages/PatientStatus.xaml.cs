using System.Windows;
using System.Windows.Controls;
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
        Patient patient = new Patient(0, Jmeno.Text, Prijemni.Text, int.Parse(RCislo.Text), Bydliste.Text, Tel.Text);
        Prijemni.Text = null;
        Jmeno.Text = null;
        RCislo.Text = null;
        Bydliste.Text = null;
        Tel.Text = null;
        Connection connection = new Connection();
        connection.InsertSQL("insert into patient (pname, surname, rnum, telnum, place)" +
                           $"values ('{patient.GetName()}', '{patient.GetSurname()}', {patient.GetRnum()}, {patient.GetPhone()}, '{patient.GetPlace()}')");
        
        NavigationService.Navigate(null);
    }
}