namespace Kyu6.BouncingBall.Tests;

public class Tests
{
    [Test]
    [Category("Positive")]
    public void BallIsSeenCountWithCorrectDataReturnsCorrectValue()
    {
        //Arrange
        double height = 10;
        double bounceRate = 0.3;
        double windowHeight = 0.2;

        //Act
        int actual = Kata.BallIsSeenCount(height, bounceRate, windowHeight);

        //Assert
        Assert.That(actual, Is.EqualTo(7));
    }

    [Test]
    [Category("Positive")]
    [Category("Boundary Value")]
    [Description("Ball is seen exactly one time")]
    public void BallIsSeenCountWithBottomBoundaryReturnsOne()
    {
        //Arrange
        double height = 2;
        double bounceRate = 0.5;
        double windowHeight = 1;

        //Act
        int actual = Kata.BallIsSeenCount(height, bounceRate, windowHeight);

        //Assert
        Assert.That(actual, Is.EqualTo(1));
    }
}