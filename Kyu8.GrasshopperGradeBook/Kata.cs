namespace Kyu8.GrasshopperGradeBook;

public class Kata
{
    public static char GetGrade(int firstGrade, int secondGrade, int thirdGrade)
    {
        double average = (firstGrade + secondGrade + thirdGrade) / 3.0;
        if (average < 60)
        {
            return 'F';
        }
        else if (average < 70)
        {
            return 'D';
        }
        else if (average < 80)
        {
            return 'C';
        }
        else if (average < 90)
        {
            return 'B';
        }

        return 'A';
    }
}
