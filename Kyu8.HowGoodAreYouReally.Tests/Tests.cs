namespace Kyu8.HowGoodAreYouReally.Tests;

public class Tests
{
    [Test]
    public void BetterThanAverageWithLowerAverageReturnsTrue()
    {
        //Arrange
        int[] grades = [1, 2, 3, 4, 5];
        int myGrade = 4;

        //Act
        bool actual = Kata.BetterThanAverage(grades, myGrade);

        //Assert
        Assert.That(actual, Is.True);
    }
}