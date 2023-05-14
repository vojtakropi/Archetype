using System;
using System.Collections.Generic;
using System.Linq;
using WpfApp1.Archetypes;
using WpfApp1.Archetypes.Patient;
using WpfApp1.Database;

namespace WpfApp1.page_Classes;

public class MainWindowClass
{
    private List<Patient> _patients;
    

    public MainWindowClass(MainWindow mainWindow)
    {
        _patients = new List<Patient>();
        
    }

    public void AddPatient(Patient patient)
    {
        _patients.Add(patient);
    }

    public List<Patient> GetPatients()
    {
        Connection connection = new Connection();
        var patients = connection.GetPatients();
        _patients = patients;
        return _patients;
    }

    public Patient GetPatientByName(String name)
    {
        var fullname = name.Split(" ");
        var firstname = fullname[0];
        var surname = fullname[1];
        Patient p = _patients.First(a => a.GetName() == firstname && a.GetSurname() == surname);
        return p;
    }
    
    
}