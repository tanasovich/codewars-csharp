namespace Kyu8.TheFallingSpeedOfPetals.Tests;

public class Tests
{
    [Test]
    [Category("Positive")]
    public void SakuraFallWithCorrectSpeedReturnsCorrectTime()
    {
        //Arrange
        double velocity = 10;
        double expected = 40;

        //Act
        double actual = Kata.SakuraFall(velocity);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}