using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using WpfApp1.Archetypes.Patient;

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
            MessageBox.Show("Cannot open connection!");
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
            MessageBox.Show("Cannot open connection!");
        }
        return patients;
    }
}