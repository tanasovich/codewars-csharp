namespace Kyu8.CuboidVolume.Tests;

public class Tests
{
    [Test]
    [Category("Positive")]
    public void GetVolumeOfCuboidWithCorrectValueReturnsCorrectValue()
    {
        // Arrange
        double length = 3;
        double width = 4;
        double height = 5;
        double expected = 60;

        // Act
        double actual = Kata.GetVolumeOfCuboid(length, width, height);

        // Assert
        Assert.That(actual, Is.EqualTo(expected).Within(1e-4));
    }
}