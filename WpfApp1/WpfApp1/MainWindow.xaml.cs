using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Archetypes;
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
        private Patient activePatient;

        public MainWindow()
        {
            InitializeComponent();
            _mainWindowClassWindow = new MainWindowClass();
            _patientStatus = new PatientStatus(_mainWindowClassWindow);
            Tools.Visibility = Visibility.Hidden;

        }

        
        private void HelloWorldButton_Click(object sender, RoutedEventArgs e)
        {
            
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