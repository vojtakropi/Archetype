using System.Collections.Generic;

namespace WpfApp1.Archetypes.Observatory;

public class BloodPressure_object
{
    private int _systolic;
    private int _diastolic;
    private int _pulse;
    private decimal _meanArterial;
    private string _position;
    private string _sleepstatus;
    private string _comment;


    public BloodPressure_object(int systolic, int diastolic, int pulse, decimal meanArterial, string position, string sleepstatus, string comment)
    {
        _systolic = systolic;
        _diastolic = diastolic;
        _pulse = pulse;
        _meanArterial = meanArterial;
        _position = position;
        _sleepstatus = sleepstatus;
        _comment = comment;
    }
    
    

    public int GetSystolic()
    {
        return _systolic;
    }
    public int GetDiastolic()
    {
        return _diastolic;
    }
    public int GetPulse()
    {
        return _pulse;
    }
    public decimal GetMeanArterieal()
    {
        return _meanArterial;
    }
    public string GetPosition()
    {
        return _position;
    }
    public string GetSleepStatus()
    {
        return _sleepstatus;
    }

    public string GetComment()
    {
        return _comment;
    }
}