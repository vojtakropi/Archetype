using System.Collections.Generic;

namespace WpfApp1.Archetypes.Observatory;

public class BloodPressure
{
    private int Systolic;
    private int Diastolic;
    private int pulse;
    private int meanArterial;
    private string position;
    private int sleepstatus;
    private Dictionary<string, int> positions = new()
    {
        {"stojící", 1},
        {"sedící", 2},
        {"ležící", 3},
        {"ležící s nákolenm doleva", 4}
    };

    public BloodPressure(int systolic, int diastolic, int pulse, int meanArterial, string position, int sleepstatus)
    {
        Systolic = systolic;
        Diastolic = diastolic;
        this.pulse = pulse;
        this.meanArterial = meanArterial;
        this.position = position;
        this.sleepstatus = sleepstatus;
    }

    public int GetSystolic()
    {
        return Systolic;
    }
    public int GetDiastolic()
    {
        return Diastolic;
    }
    public int GetPulse()
    {
        return pulse;
    }
    public int GetMeanArterieal()
    {
        return meanArterial;
    }
    public string GetPosition()
    {
        return position;
    }
    public int GetSleepStatus()
    {
        return sleepstatus;
    }
    
    
}