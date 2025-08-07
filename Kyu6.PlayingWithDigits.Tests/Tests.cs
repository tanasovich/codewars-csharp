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
}