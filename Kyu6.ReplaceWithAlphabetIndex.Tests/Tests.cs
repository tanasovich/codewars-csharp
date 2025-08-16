namespace Kyu6.ReplaceWithAlphabetIndex.Tests;

public class Tests
{
    [Test]
    [Category("Positive")]
    public void AlphabetPositionWithLettersReturnsLetterIndexes()
    {
        // Arrange
        string letters = "HelloWorld";
        string expected = "8 5 12 12 15 23 15 18 12 4";

        // Act
        string actual = Kata.AlphabetPosition(letters);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Category("Positive")]
    [TestCase("\tHello World", Description = "Ignores white spaces")]
    [TestCase("Hel2lo0World5", Description = "Ignores digits")]
    [TestCase("@HelloW#$orld", Description = "Ignores special chars")]
    public void AlphabetPositionWithMixedTextIgnoresNonLetters(string source)
    {
        // Arrange
        string expected = "8 5 12 12 15 23 15 18 12 4";

        // Act
        string actual = Kata.AlphabetPosition(source);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
