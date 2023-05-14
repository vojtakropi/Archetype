using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using WpfApp1.Archetypes.Evaulation;
using WpfApp1.Archetypes.medication;
using WpfApp1.Archetypes.Observatory;
using WpfApp1.Archetypes.Patient;
using WpfApp1.Database;
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
            _mainWindowClassWindow = new MainWindowClass(this);
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
            IcVis.Visibility = Visibility.Hidden;
            List<Button> buttons = new List<Button>();
            foreach (var patient in _mainWindowClassWindow.GetPatients())
            {
                buttons.Add(new Button { ButtonContent = patient.GetName() + " " + patient.GetSurname()});
            }
            Ic.ItemsSource = buttons;
            Ic.Visibility = Visibility.Visible;
        }
        
        private void ChoosePatient_Click(object sender, RoutedEventArgs e)
        {
            Ic.Visibility = Visibility.Hidden;
            Tools.Visibility = Visibility.Visible;
            _activePatient = _mainWindowClassWindow.GetPatientByName(((System.Windows.Controls.Button)sender).Content.ToString()!);
            name.Content = _activePatient.GetName();
            surname.Content = _activePatient.GetSurname();
            rnum.Content = _activePatient.GetRnum();
            Connection connection = new Connection();
            List<Tuple<DateTime, string>> visits; 
            connection.GetVisits(_activePatient.GetId(), out visits);
            AddButtons(visits);
        }

        public void AddButtons(List<Tuple<DateTime, string>> visits)
        {
            List<Button> buttons = new List<Button>();
            foreach (var visit in visits)
            {
                buttons.Add(new Button { ButtonContent = visit.Item1 + ";  " + visit.Item2});
            }
            IcVis.ItemsSource = buttons;
            IcVis.Visibility = Visibility.Visible;
        }

        public Patient GetPatient()
        {
            return _activePatient;
        }

        private void Button_Click_ChooseVisit(object sender, RoutedEventArgs e)
        {
            var content = ((System.Windows.Controls.Button)sender).Content.ToString();
            var date = content!.Split(";");
            var type = date[1].Replace(" ", "");
            var datetime = DateTime.Parse(date[0]);
            Connection connection = new Connection();

            switch (type)
            {
               case "BMI":
                   BMI_object bmiObject = connection.GetBMIdetail(_activePatient.GetId(), datetime);
                   var bmi = new Bmi(this);
                   bmi.bmi.Text = bmiObject.GetBmi().ToString(CultureInfo.InvariantCulture);
                   bmi.cofounding.Text = bmiObject.GetConfoundingF();
                   bmi.comment.Text = bmiObject.GetComment();
                   bmi.interpret.Text = bmiObject.GetInterpret();
                   bmi.save.Visibility = Visibility.Hidden;
                   Main.Content = bmi;
                   break;
               case "Krevnítlak":
                   BloodPressure_object bloodPressureObject = connection.GetBloodPressuredetail(_activePatient.GetId(), datetime);
                   var bloodpressure = new BloodPressure(this);
                   bloodpressure.dia.Text = bloodPressureObject.GetDiastolic().ToString();
                   bloodpressure.sys.Text = bloodPressureObject.GetSystolic().ToString();
                   bloodpressure.art.Text = bloodPressureObject.GetMeanArterieal().ToString(CultureInfo.InvariantCulture);
                   bloodpressure.comment.Text = bloodPressureObject.GetComment();
                   bloodpressure.puls.Text = bloodPressureObject.GetPulse().ToString();
                   bloodpressure.sleep.Text = bloodPressureObject.GetSleepStatus();
                   bloodpressure.pos.Text = bloodPressureObject.GetPosition();
                   bloodpressure.save.Visibility = Visibility.Hidden;
                   Main.Content = bloodpressure;
                   break;
               case "Zdravotnírizika":
                   HealtRiskAssessment_object healtRiskAssessmentObject = connection.GetHealtRiskdetail(_activePatient.GetId(), datetime);
                   var healthRiskAssesment = new HealthRiskAssesment(this);
                   healthRiskAssesment.comment.Text = healtRiskAssessmentObject.GetComment();
                   healthRiskAssesment.risk.Text = healtRiskAssessmentObject.GethealthRisk();
                   healthRiskAssesment.isin.Text = healtRiskAssessmentObject.GetPresenece();
                   healthRiskAssesment.methode.Text = healtRiskAssessmentObject.GetAssesmentMethode();
                   healthRiskAssesment.namerisk.Text = healtRiskAssessmentObject.GetDescription();
                   healthRiskAssesment.save.Visibility = Visibility.Hidden;
                   Main.Content = healthRiskAssesment;
                   break;
               case "Váha":
                   Weight_object weightObject = connection.GetWeightdetail(_activePatient.GetId(), datetime);
                   var weight = new Weight(this);
                   weight.weight.Text = weightObject.GetWeight().ToString(CultureInfo.InvariantCulture);
                   weight.comment.Text = weightObject.GetComment();
                   weight.cofounding.Text = weightObject.GetCofoundingF();
                   weight.stateofclotsh.Text = weightObject.GetStateOfD();
                   weight.save.Visibility = Visibility.Hidden;
                   Main.Content = weight; 
                   break;
               case "Medikace":
                   Medication_object medicationObject =
                       connection.GetMedicationdetail(_activePatient.GetId(), datetime);
                   var medication = new Medication(this);
                   medication.medication.Text = medicationObject.GetMedication();
                   medication.comment.Text = medicationObject.GetComment();
                   medication.amount.Text = medicationObject.GetAmount().ToString(CultureInfo.InvariantCulture);
                   medication.insertion.Text = medicationObject.GetRoute();
                   medication.place.Text = medicationObject.GetBodySite();
                   medication.unit.Text = medicationObject.GetUnit();
                   medication.save.Visibility = Visibility.Hidden;
                   Main.Content = medication;
                   break;
            }
        }
    }
    class Button
    {
        public string ButtonContent { get; set; }
    }
}