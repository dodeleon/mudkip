namespace Cpsc370Final.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
    }

    [Fact]
    public void Constructor_ShouldInitializePropertiesCorrectly()
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
    
}