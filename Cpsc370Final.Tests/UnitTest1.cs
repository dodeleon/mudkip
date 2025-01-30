namespace Cpsc370Final.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
    }

    [Fact]
    public void FeatsTest()
    {
        // Arrange
        string expectedFeatName = "Test Feat"; 
        string expectedFeatDescription = "This is a test feat description.";

        // Act
        Feat feat = new Feat(expectedFeatName, expectedFeatDescription);

        // Assert
        Assert.Equal(expectedFeatName, feat.FeatName);
        Assert.Equal(expectedFeatDescription, feat.FeatDescription);
        
    }
    
    [Fact]
    public void SpellsTestConstructor()
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