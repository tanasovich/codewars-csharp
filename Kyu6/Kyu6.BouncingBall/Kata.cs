namespace Kyu6.BouncingBall;

public class Kata
{
    /// <summary>
    /// Intersection of two functions is used to find number of ball appearances
    /// at window level (including <i>jumping</i> and <i>falling</i>).
    /// <para>
    /// Ball height progression follows function: y = -bounceRate^x * initBallHeight
    /// <br/>
    /// </para>
    /// <para>
    /// Intersection of two functions gives us number of ball appearences only.
    /// <br/>
    /// To provide correct answer, we double this number (jumps and falls) and
    /// add extra one, because ball is seen one time as minimum at the
    /// beginning.
    /// </para>
    /// </summary>
    /// <param name="initBallHeight">
    ///     initial ball height above the ground
    /// </param>
    /// <param name="bounceRate">
    ///     how much ball loses height with each bounce
    /// </param>
    /// <param name="windowHeight">height of the window</param>
    /// <returns>number of times, ball is seen from window</returns>
    public static int BallIsSeenCount(double initBallHeight, double bounceRate, double windowHeight)
    {
        if (initBallHeight <= 0 || bounceRate <= 0
            || bounceRate >= 1 || windowHeight >= initBallHeight)
        {
            return -1;
        }

        if (initBallHeight * bounceRate == windowHeight)
        {
            return 1;
        }

        return 2 * (int)Math.Floor(
            Math.Log(windowHeight / initBallHeight) / Math.Log(bounceRate)
        ) + 1;
    }
}
