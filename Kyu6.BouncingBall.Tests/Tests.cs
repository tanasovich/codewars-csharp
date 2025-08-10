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
}