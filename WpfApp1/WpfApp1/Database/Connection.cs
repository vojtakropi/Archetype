using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Documents;
using WpfApp1.Archetypes.Evaulation;
using WpfApp1.Archetypes.medication;
using WpfApp1.Archetypes.Observatory;
using WpfApp1.Archetypes.Patient;
using WpfApp1.Pages;

namespace WpfApp1.Database;
using MySql.Data.MySqlClient;
public class Connection
{
    private const string MyConnectionString = "server=localhost;database=biomedicalapp;uid=root;pwd=Vojtakropi20;";

    public void InsertSQL(string sql)
    {
        MySqlConnection cnn = new MySqlConnection(MyConnectionString);
        var command = cnn.CreateCommand();
        command.CommandText = sql;
        try
        {
            cnn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            cnn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        
    }
    
    public List<Patient> GetPatients(){
        MySqlConnection cnn = new MySqlConnection(MyConnectionString);
        var command = cnn.CreateCommand();
        command.CommandText = "select * from patient";
        List<Patient> patients = new List<Patient>();
        try
        {
            cnn.Open();
            MySqlDataReader reader = command.ExecuteReader();
                
            while (reader.Read())
            {
                patients.Add(new Patient(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3),
                    reader.GetString(4), reader.GetString(5)));
            }
            cnn.Close();
            return patients;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        return patients;
    }


    public void GetVisits(int id, out List<Tuple<DateTime, String>> visits)
    {
        MySqlConnection cnn = new MySqlConnection(MyConnectionString);
        var command = cnn.CreateCommand();
        visits = new List<Tuple<DateTime, string>>();
        
        command.CommandText = $"select * from blood_pressure where PatientID = {id}";
        try
        {
            cnn.Open();
            MySqlDataReader reader = command.ExecuteReader();
                
            while (reader.Read())
            {
                visits.Add(Tuple.Create(reader.GetDateTime(8), "Krevní tlak"));
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        
        command.CommandText = $"select * from bmi where PatientID = {id}";
        try
        {
            cnn.Open();
            MySqlDataReader reader = command.ExecuteReader();
                
            while (reader.Read())
            {
                visits.Add(Tuple.Create(reader.GetDateTime(6), "BMI"));
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        
        command.CommandText = $"select * from health_risk_assesment where patientID = {id}";
        try
        {
            cnn.Open();
            MySqlDataReader reader = command.ExecuteReader();
                
            while (reader.Read())
            {
                visits.Add(Tuple.Create(reader.GetDateTime(7), "Zdravotní rizika"));
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        
        command.CommandText = $"select * from weight where patientID = {id}";
        try
        {
            cnn.Open();
            MySqlDataReader reader = command.ExecuteReader();
                
            while (reader.Read())
            {
                visits.Add(Tuple.Create(reader.GetDateTime(6), "Váha"));
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
        command.CommandText = $"select * from medication where patientID = {id}";
        try
        {
            cnn.Open();
            MySqlDataReader reader = command.ExecuteReader();
                
            while (reader.Read())
            {
                visits.Add(Tuple.Create(reader.GetDateTime(8), "Medikace"));
            }
            cnn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
    public object GetVisitDetail(int id, DateTime dateTime, string value)
    {
        
        MySqlConnection cnn = new MySqlConnection(MyConnectionString);
        var command = cnn.CreateCommand();

        switch (value)
        {
            case "Krevní tlak":
                command.CommandText = $"select * from blood_pressure where PatientID = {id} and date = '{dateTime}'";
                try
                {
                    cnn.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                
                    if (reader.Read())
                    {
                        return new BloodPressure_object(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetDecimal(4),
                            reader.GetString(5), reader.GetString(6), reader.GetString(7));
                    }
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                break;
            case "BMI":
                command.CommandText = $"select * from bmi where PatientID = {id} and date = '{dateTime}'";
                try
                {
                    cnn.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                
                    if (reader.Read())
                    {
                        return new BMI_object(reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    }
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                break;
            case "Zdravotní rizika":
                command.CommandText = $"select * from health_risk_assesment where patientID = {id} and date = '{dateTime}'";
                try
                {
                    cnn.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                
                    if (reader.Read())
                    {
                        return new HealtRiskAssessment_object(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4),
                            reader.GetString(5), reader.GetString(6));
                    }
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection!");
                }
                break;
            case "Váha":
                command.CommandText = $"select * from weight where patientID = {id} and date = '{dateTime}'";
                try
                {
                    cnn.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                
                    while (reader.Read())
                    {
                        return new Weight_object(reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    }
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                break;
            case "Medikace":
                command.CommandText = $"select * from medication where patientID = {id} and date = '{dateTime}'";
                try
                {
                    cnn.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                
                    if (reader.Read())
                    {
                        return new Medication_object(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDecimal(4),
                            reader.GetString(5), reader.GetString(6));
                    }
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                break;
            default:
                return null;
        }

        return null;
    }
}