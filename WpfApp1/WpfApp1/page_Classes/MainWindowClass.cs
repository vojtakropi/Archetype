using System;
using System.Collections.Generic;
using System.Linq;
using WpfApp1.Archetypes;
using WpfApp1.Archetypes.Patient;

namespace WpfApp1.page_Classes;

public class MainWindowClass
{
    private List<Patient> _patients;

    public MainWindowClass()
    {
        _patients = new List<Patient>();
    }

    public void AddPatient(Patient patient)
    {
        _patients.Add(patient);
    }

    public List<Patient> GetPatients()
    {
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