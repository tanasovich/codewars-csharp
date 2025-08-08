namespace Kyu8.InvertValues.Tests;

public class Tests
{
    [Test]
    [Category("Positive")]
    public void InvertValuesWithPositiveNumberReturnsNegativeNumber()
    {
        //Arrange
        int[] numbers = [1, 2, 3];
        int[] expected = [-1, -2, -3];

        //Act
        int[] actual = Kata.InvertValues(numbers);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
