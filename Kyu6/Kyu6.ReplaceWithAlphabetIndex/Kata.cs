namespace Kyu6.ReplaceWithAlphabetIndex;

public class Kata
{
    public static string AlphabetPosition(string text)
    {
        return String.Join(" ", text.Aggregate(new List<byte>(), (codes, x) =>
        {
            if (!Char.IsLetter(x))
            {
                return codes;
            }
            codes.Add(GetAlphabeticalPosition(x));
            return codes;
        }));
    }

    private static byte GetAlphabeticalPosition(char character)
    {
        return (byte)(Char.ToLower(character) - 'a' + 1);
    }
}
