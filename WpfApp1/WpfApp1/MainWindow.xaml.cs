﻿using System.Collections.Generic;
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
        private Patient _activePatient;

        public MainWindow()
        {
            InitializeComponent();
            _mainWindowClassWindow = new MainWindowClass();
            //Tools.Visibility = Visibility.Hidden;
        }

        
        private void BMI_Click(object sender, RoutedEventArgs e)
        {
            var bmi = new Bmi(this);
            Main.Content = bmi;
            
        }
        private void Medication_Click(object sender, RoutedEventArgs e)
        {
            var medication = new Medication(this);
            Main.Content = medication;
        }
        private void Weight_Click(object sender, RoutedEventArgs e)
        {
            var weight = new Weight(this);
            Main.Content = weight;
        }
        private void BloodPressure_Click(object sender, RoutedEventArgs e)
        {
            var bloodPressure = new BloodPressure(this);
            Main.Content = bloodPressure;
        }
        private void HealthRiskAssesment_Click(object sender, RoutedEventArgs e)
        {
            var healthRiskAssesment = new HealthRiskAssesment(this);
            Main.Content = healthRiskAssesment;
        }

        private void Button_Click_NewPatient(object sender, RoutedEventArgs e)
        {
            var patientStatus = new PatientStatus(_mainWindowClassWindow);
            Main.Content = patientStatus;

        }
        
        private void Button_Click_ChoosePatient(object sender, RoutedEventArgs e)
        {
            List<Button> buttons = new List<Button>();
            foreach (var patient in _mainWindowClassWindow.GetPatients())
            {
                buttons.Add(new Button { ButtonContent = patient.GetName() + " " + patient.GetSurname()});
            }
            Ic.ItemsSource = buttons;
            Ic.Visibility = Visibility.Visible;
        }
        
        private void HelloWorldButton2_Click(object sender, RoutedEventArgs e)
        {
            Tools.Visibility = Visibility.Visible;
            _activePatient = _mainWindowClassWindow.GetPatientByName(((System.Windows.Controls.Button)sender).Content.ToString()!);
            name.Content = _activePatient.GetName();
            surname.Content = _activePatient.GetSurname();
            rnum.Content = _activePatient.GetRnum();
            Ic.Visibility = Visibility.Hidden;

        }

        public Patient GetPatient()
        {
            return _activePatient;
        }
    }
    class Button
    {
        public string ButtonContent { get; set; }
    }
}