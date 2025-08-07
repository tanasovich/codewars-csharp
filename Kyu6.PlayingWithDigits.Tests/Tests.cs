namespace Kyu6.PlayingWithDigits.Tests;

public class Tests
{
    [Test]
    [Category("Positive")]
    public void DigitsPowerWithCorrectNumberReturnsCorrectValue()
    {
        //Arrange
        int number = 46288;
        int firstPower = 3;
        int expected = 51;

        //Act
        long actual = Kata.DigitsPower(number, firstPower);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [Category("Negative")]
    public void DigitsPowerWithCorrectNumberReturnsMinusOne()
    {
        //Arrange
        int number = 92;
        int firstPower = 1;
        int expected = -1;

        //Act
        long actual = Kata.DigitsPower(number, firstPower);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
