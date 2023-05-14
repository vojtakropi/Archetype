using System;

namespace WpfApp1.Archetypes.Evaulation;

public class HealtRiskAssessment_object
{
    private string healthRisk;

    private string riskFactor;

    private string presence;

    private string assesmentMethode;

    private string comment;

    public HealtRiskAssessment_object(string healthRisk, string riskFactor, string presence, string assesmentMethode, string comment)
    {
        this.healthRisk = healthRisk;
        this.riskFactor = riskFactor;
        this.presence = presence;
        this.assesmentMethode = assesmentMethode;
        this.comment = comment;
    }

    public string GethealthRisk()
    {
        return healthRisk;
    }
    public string GetRiskFactor()
    {
        return riskFactor;
    }
    public string GetPresenece()
    {
        return presence;
    }
    public string GetDescription()
    {
        return healthRisk;
    }
    public string GetAssesmentMethode()
    {
        return assesmentMethode;
    }
    public string GetComment()
    {
        return comment;
    }
}