namespace Kyu6.PlayingWithDigits;

public class Kata
{
    public static long DigitsPower(int number, int firstPower)
    {
        int currentNumber = number;
        int lastPower = firstPower + CountNumberOfDigits(number) - 1;
        long powerOfDigitsSum = 0;

        for (int i = lastPower; i >= firstPower; i--)
        {
            int digit = currentNumber % 10;
            currentNumber /= 10;

            powerOfDigitsSum += (long) Math.Pow(digit, i);
        }

        long quotient = powerOfDigitsSum / number;

        return (powerOfDigitsSum % number == 0)? quotient : -1;
    }

    public static int CountNumberOfDigits(int number)
    {
        return (int) Math.Floor(Math.Log10(number)) + 1;
    }
}
