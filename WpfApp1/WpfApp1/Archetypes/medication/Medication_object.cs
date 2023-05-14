namespace WpfApp1.Archetypes.medication;

public class Medication_object
{
    private string medication;

    private string route;

    private string bodySite;

    private decimal amount;

    private string comment;

    private string unit;

    public Medication_object(string medication, string route, string bodySite, decimal amount, string comment, string unit)
    {
        this.medication = medication;
        this.route = route;
        this.bodySite = bodySite;
        this.amount = amount;
        this.comment = comment;
        this.unit = unit;
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

    public string GetComment()
    {
        return comment;
    }

    public string GetUnit()
    {
        return unit;
    }

    public decimal GetAmount()
    {
        return amount;
    }
    
}