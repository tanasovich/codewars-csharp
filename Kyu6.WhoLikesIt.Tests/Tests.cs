namespace Kyu6.WhoLikesIt.Tests;

public class Tests
{
    [Test]
    public void LikesWitOneNameReturnsCorrectLikes()
    {
        //Arrange
        string[] names = new string[] { "Valentine" };
        string expected = "Valentine likes this";

        //Act
        string actual = Kata.Likes(names);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void LikesWitTwoNamesReturnsCorrectLikes()
    {
        //Arrange
        string[] names = new string[] { "Valentine", "Vlad" };
        string expected = "Valentine and Vlad like this";

        //Act
        string actual = Kata.Likes(names);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void LikesWitThreeNamesReturnsCorrectLikes()
    {
        //Arrange
        string[] names = new string[] { "Valentine", "Vlad", "Joaquín" };
        string expected = "Valentine, Vlad and Joaquín like this";

        //Act
        string actual = Kata.Likes(names);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void LikesWithoutNamesReturnsNobodyLikes()
    {
        //Arrange
        string[] names = new string[0];
        string expected = "no one likes this";

        //Act
        string actual = Kata.Likes(names);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}