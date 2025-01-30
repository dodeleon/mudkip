namespace Cpsc370Final;

public class Spells
{
    //name,type,description
    public string Name { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    

    public Spells()
    {
        Name = "Default Spell";
        Type = "Default Type";
        Description = "Default Description";
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
    
    public string getDescription()
    {
        return Description;
    }
    public void setDescription(string Description)
    {
        this.Description = Description;
    }
    
}