namespace Kyu6.HelpTheBookSeller.Tests;

public class Tests
{
    [Test]
    [Category("Smoke")]
    [Category("Positive")]
    public void StockSummaryWithValidDataReturnsCorrectList()
    {
        //Arrange
        string[] stockList = [
            "ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"
        ];
        string[] categories = ["A", "B", "C", "W"];
        string expected = "(A : 20) - (B : 114) - (C : 50) - (W : 0)";

        //Act
        string actual = Kata.StockSummary(stockList, categories);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}