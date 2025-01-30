namespace Cpsc370Final;

public class Spells
{
    //name,type,description
    public string Name { get; set; }
    public string Type { get; set; }
    public string Damage { get; set; }
    

    public Spells(string Name, string Type, string Damage)
    {
        this.Name = Name;
        this.Type = Type;
        this.Damage = Damage;
    }
    
    //Getters and Setters
    public string getName()
    {
        return Name;
    }
    public void setName(string Name)
    {
        this.Name = Name;
    }
    
    public string getType()
    {
        return Type;
    }
    public void setType(string Type)
    {
        this.Type = Type;
    }
    
    public string getDamage()
    {
        return Damage;
    }
    public void setDamage(string Damage)
    {
        this.Damage = Damage;
    }
    
}