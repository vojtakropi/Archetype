namespace WpfApp1.Archetypes.medication;

public class Medication
{
    private string medication;

    private string route;

    private string bodySite;

    public Medication(string medication, string route, string bodySite)
    {
        this.medication = medication;
        this.route = route;
        this.bodySite = bodySite;
    }

    public string GetMedication()
    {
        return medication;
    }
    public string GetRoute()
    {
        return route;
    }
    public string GetBodySite()
    {
        return bodySite;
    }
    
    
}