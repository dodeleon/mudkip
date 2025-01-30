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
    public void Race_Constructor()
    {
        // Arrange
        string expectedName = "Test Race";
        int? expectedApproxMaxAge = 200;
        string expectedAlignmentDescription = "Neutral alignment test";
        string expectedSizeCategory = "Medium";
        string expectedSpeedDescription = "Your base walking speed is 30 feet.";

        // Act
        Race testRace = new Race(
            expectedName,
            expectedApproxMaxAge,
            expectedAlignmentDescription,
            expectedSizeCategory,
            expectedSpeedDescription
        );

        // Assert
        Assert.Equal(expectedName, testRace.Name);
        Assert.Equal(expectedApproxMaxAge, testRace.ApproximateMaxAge);
        Assert.Equal(expectedAlignmentDescription, testRace.AlignmentDescription);
        Assert.Equal(expectedSizeCategory, testRace.SizeCategory);
        Assert.Equal(expectedSpeedDescription, testRace.SpeedDescription);
    }
    
    

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
