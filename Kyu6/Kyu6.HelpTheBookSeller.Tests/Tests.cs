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

    [Test]
    [Category("Negative")]
    public void StockSummaryWithEmptyStockListReturnsEmptyString()
    {
        //Arrange
        string[] stockList = [];
        string[] categories = ["A", "B", "C", "W"];
        string expected = "";

        //Act
        string actual = Kata.StockSummary(stockList, categories);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [Category("Negative")]
    public void StockSummaryWithEmptyCategoriesReturnsEmptyString()
    {
        //Arrange
        string[] stockList = [
            "ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60"
        ];
        string[] categories = [];
        string expected = "";

        //Act
        string actual = Kata.StockSummary(stockList, categories);

        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}