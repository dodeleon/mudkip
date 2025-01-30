namespace Cpsc370Final.Tests;

public class UnitTest1
{
    [Fact]
    public void SpellsTest()
    {
        //Arrange
        string ExpectedName = "Fire";
        string ExpectedType = "Abjuration";
        string ExpecetedDamage = "5";
        
        //Act
        Spells spells = new Spells(ExpectedName, ExpectedType, ExpecetedDamage);
        
        //Assert
        Assert.Equal(ExpectedName, spells.Name);
        Assert.Equal(ExpectedType, spells.Type);
        Assert.Equal(ExpecetedDamage, spells.Damage);
    }
    
    
}