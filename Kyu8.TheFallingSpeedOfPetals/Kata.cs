namespace Kyu8.TheFallingSpeedOfPetals;

public class Kata
{
    /// <summary>
    /// To fall down from branch <i>x<i/>, petal with velocity 5 cm/s takes
    /// 80 seconds. So, branch is at the 5 * 80 = 400 cm height above
    /// the ground.
    /// </summary>
    /// <remarks>
    /// Height is in centimeters.
    /// </remarks>
    private static readonly int BRANCH_HEIGHT = 400;

    public static double SakuraFall(double petalVelocity)
    {
        if (petalVelocity <= 0)
        {
            return 0;
        }
        
        return BRANCH_HEIGHT / petalVelocity;
    }
}
