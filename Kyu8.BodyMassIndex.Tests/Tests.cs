namespace Kyu8.BodyMassIndex.Tests;

public class Tests
{
    [TestCase(60.607, 1.81)]
    [TestCase(70, 26.4575)]
    public void BmiWithSlimBodyReturnsUnderweight(double weight, double height)
    {
        // Arrange
        string expected = "Underweight";

        // Act
        string actual = Kata.Bmi(weight, height);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase(70, 1.676)]
    [TestCase(60.6079, 1.81)]
    public void BmiWithNormalBodyReturnsNormal(double weight, double height)
    {
        // Arrange
        string expected = "Normal";

        // Act
        string actual = Kata.Bmi(weight, height);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}