namespace Kyu8.InvertValues;

public class Kata
{
    public static int[] InvertValues(int[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = -input[i];
        }
        
        return input;
    }
}
