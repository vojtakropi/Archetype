namespace WpfApp1.Archetypes.Observatory;

public class Weight
{
    private int weight;

    private string comment;

    private string stateOfDress;

    private string cofoundingF;

    public Weight(int weight, string comment, string stateOfDress, string cofoundingF)
    {
        this.weight = weight;
        this.comment = comment;
        this.stateOfDress = stateOfDress;
        this.cofoundingF = cofoundingF;
    }

    public int GetWeight()
    {
        return weight;
    }

    public string GetComment()
    {
        return comment;
    }
    public string GetStateOfD()
    {
        return stateOfDress;
    }
    public string GetCofoundingF()
    {
        return cofoundingF;
    }
}