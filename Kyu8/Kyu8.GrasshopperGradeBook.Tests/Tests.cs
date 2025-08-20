namespace Kyu8.GrasshopperGradeBook.Tests;

public class Tests
{
    [Test]
    [Category("Boundary Value")]
    [TestCase(0, 0, 0, ExpectedResult = 'F')]
    [TestCase(59, 59, 59, ExpectedResult = 'F')]
    [TestCase(60, 60, 60, ExpectedResult = 'D')]
    [TestCase(69, 69, 69, ExpectedResult = 'D')]
    [TestCase(70, 70, 70, ExpectedResult = 'C')]
    [TestCase(79, 79, 79, ExpectedResult = 'C')]
    [TestCase(80, 80, 80, ExpectedResult = 'B')]
    [TestCase(89, 89, 89, ExpectedResult = 'B')]
    [TestCase(90, 90, 90, ExpectedResult = 'A')]
    [TestCase(100, 100, 100, ExpectedResult = 'A')]
    public char GetGradeWithBoundaryValuesReturnsCorrectGrade(int first, int second, int third)
    {
        return Kata.GetGrade(first, second, third);
    }
}