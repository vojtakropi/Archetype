using System.Collections.Generic;
using System.Windows;
using WpfApp1.Archetypes.Patient;
using WpfApp1.page_Classes;
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowClass _mainWindowClassWindow;
        private PatientStatus _patientStatus;
        private Bmi _bmi;
        private BloodPressure _bloodPressure;
        private Weight _weight;
        private Patient activePatient;

        public MainWindow()
        {
            InitializeComponent();
            _mainWindowClassWindow = new MainWindowClass();
            _patientStatus = new PatientStatus(_mainWindowClassWindow);
            _bmi = new Bmi();
            _bloodPressure = new BloodPressure();
            _weight = new Weight();
            //Tools.Visibility = Visibility.Hidden;

        }

        
        private void BMI_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = _bmi;
        }
        private void Weight_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = _weight;
        }
        private void BloodPressure_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = _bloodPressure;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = _patientStatus;

        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<Button> buttons = new List<Button>();
            foreach (var patient in _mainWindowClassWindow.GetPatients())
            {
                buttons.Add(new Button { ButtonContent = patient.GetName() + " " + patient.GetSurname()});
            }
            
            Ic.ItemsSource = buttons;
        }
        
        private void HelloWorldButton2_Click(object sender, RoutedEventArgs e)
        {

            Tools.Visibility = Visibility.Visible;
            activePatient = _mainWindowClassWindow.GetPatientByName(((System.Windows.Controls.Button)sender).Content.ToString()!);

        }
        
    }
    class Button
    {
        public string ButtonContent { get; set; }
    }
}