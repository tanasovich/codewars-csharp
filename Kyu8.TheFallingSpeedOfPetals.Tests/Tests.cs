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

    [Test]
    [Category("Positive")]
    [Category("Boundary Value")]
    public void SakuraFallWithValidEdgeValueReturnsCorrectTime()
    {
        //Arrange
        double velocity = 1e-4;
        double expected = 400 / velocity; // distance / speed = time

        //Act
        double actual = Kata.SakuraFall(velocity);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}