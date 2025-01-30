namespace DefaultNamespace;

public class Feats
{
    
    public string Feats { get; set; }
    public string FeatsDiscriptions { get; set; }
    
    public string FeatBenefits { get; set; }
    
    pubic string FeatBenefits(string Benefits)
    {
        FeatBenefits = Benefits;
    }
    public FeatsDiscription(string infomation)
    {
        FeatsDiscription = infomation;
    }

    public Feats(string feats)
    {
        Feats = feats;
    }
}