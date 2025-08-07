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

    [Test]
    public void BetterThanAverageWithHigherAverageReturnsFalse()
    {
        //Arrange
        int[] grades = [1, 2, 3, 4, 5];
        int myGrade = 2;

        //Act
        bool actual = Kata.BetterThanAverage(grades, myGrade);

        //Assert
        Assert.That(actual, Is.False);
    }

    [Test]
    [Category("Boundary Value")]
    public void BetterThanAverageWithEqualAverageReturnsFalse()
    {
        //Arrange
        int[] grades = [3, 3, 3, 3, 3];
        int myGrade = 3;

        //Act
        bool actual = Kata.BetterThanAverage(grades, myGrade);

        //Assert
        Assert.That(actual, Is.False);
    }

    [Test]
    [Category("Boundary Value")]
    public void BetterThanAverageWithSubtlyHigherAverageReturnsFalse()
    {
        //Arrange
        int[] grades = [1, 5, 10, 15, 20];  // Average equals to 10.1
        int myGrade = 10;

        //Act
        bool actual = Kata.BetterThanAverage(grades, myGrade);

        //Assert
        Assert.That(actual, Is.False);
    }
}
