namespace WpfApp1.Archetypes.Observatory;

public class BMI_object
{
    private int bmi;
    private string interpret;
    private string comment;
    private string confoundingF;


    public BMI_object(int bmi, string interpret, string comment, string confoundingF)
    {
        this.bmi = bmi;
        this.interpret = interpret;
        this.comment = comment;
        this.confoundingF = confoundingF;
    }

    public int GetBmi()
    {
        return bmi;
    }
    public string GetInterpret()
    {
        return interpret;
    }
    public string GetComment()
    {
        return comment;
    }
    public string GetConfoundingF()
    {
        return confoundingF;
    }
}