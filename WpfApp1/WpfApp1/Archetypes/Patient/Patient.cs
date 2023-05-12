namespace WpfApp1.Archetypes.Patient;

public class Patient
{
    private string name;

    private string surname;

    private int rnum;

    private string place;

    private int phone;


    public Patient(string name, string surname, int rnum, string place, int phone)
    {
        this.name = name;
        this.surname = surname;
        this.rnum = rnum;
        this.place = place;
        this.phone = phone;
    }

    public string GetName()
    {
        return name;
    }
    public string GetSurname()
    {
        return surname;
    }
    public int GetRnum()
    {
        return rnum;
    }
    
}