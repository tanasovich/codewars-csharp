using System.Text;

namespace Kyu6.HelpTheBookSeller;

public class Kata
{
    public static string StockSummary(String[] lstOfArt, String[] lstOf1stLetter)
    {
        if (lstOfArt.Length == 0 || lstOf1stLetter.Length == 0)
        {
            return "";
        }

        Dictionary<char, int> booksCounter = new Dictionary<char, int>();
        foreach (string book in lstOfArt)
        {
            int bookCount = int.Parse(book.Split(' ')[1]);
            bool isNewCategory = booksCounter.TryAdd(book[0], bookCount);
            if (!isNewCategory)
            {
                booksCounter[book[0]] += bookCount;
            }
        }

        StringBuilder builder = new StringBuilder();
        builder.Append($"({lstOf1stLetter[0]} : {booksCounter.GetValueOrDefault(lstOf1stLetter[0][0], 0)})");
        for (int i = 1; i < lstOf1stLetter.Length; i++)
        {
            builder.Append($" - ({lstOf1stLetter[i]} : {booksCounter.GetValueOrDefault(lstOf1stLetter[i][0], 0)})");
        }

        return builder.ToString();
    }
}
