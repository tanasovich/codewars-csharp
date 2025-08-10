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

    [Test]
    [Category("Positive")]
    [Description("Ball is seen exactly three times")]
    public void BallIsSeenCountWithTopBoundaryReturnsThree()
    {
        //Arrange
        double height = 2;
        double bounceRate = 0.5 + 1e-6;
        double windowHeight = 1;

        //Act
        int actual = Kata.BallIsSeenCount(height, bounceRate, windowHeight);

        //Assert
        Assert.That(actual, Is.EqualTo(3));
    }

    [Test]
    [TestCase(1e-5, 0.5, 1e-6, ExpectedResult = 7, Description = "Height positive edge")]
    [TestCase(0, 0.5, 21, ExpectedResult = -1, Description = "Height negative edge")]
    [TestCase(42, 1e-6, 21, ExpectedResult = 1, Description = "Bounce positive low edge")]
    [TestCase(42, 0, 21, ExpectedResult = -1, Description = "Bounce negative low edge")]
    [TestCase(42, 999999e-6, 21, ExpectedResult = 1386293, Description = "Bounce positive high edge")]
    [TestCase(42, 1, 21, ExpectedResult = -1, Description = "Bounce negative high edge")]
    public int BallIsSeenCountWithInvalidDataReturnsMinusOne(double height, double bounceRate, double windowHeight)
    {
        return Kata.BallIsSeenCount(height, bounceRate, windowHeight);
    }
}
