namespace WpfApp1.Archetypes.Patient;

public class Patient
{
    private string name;

    private string surname;

    private int rnum;

    private string place;

    private string phone;

    private int ID;


    public Patient(int id, string name, string surname, int rnum, string place, string phone)
    {
        this.name = name;
        this.surname = surname;
        this.rnum = rnum;
        this.place = place;
        this.phone = phone;
        this.ID = id;
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

    public string GetPlace()
    {
        return place;
    }

    public string GetPhone()
    {
        return phone;
    }

    public int GetId()
    {
        return ID;
    }
}