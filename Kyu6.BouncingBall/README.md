# Bouncing Ball

A child is playing with a ball on the nth floor of a tall building. The height
of this floor above ground level, *initBallHeight*, is known.

He drops the ball out of the window. The ball bounces (for example), to
two-thirds of its height. *bounceRate* equals to  0.66

His mother looks out of a *windowHeight* 1.5 meters from the ground.

How many times will the mother see the ball pass in front of her window
(including when it's falling and bouncing)?

Three conditions must be met for a valid experiment:

- `initBallHeight > 0` (in meters)
- `0 < bounceRate < 1`
- `windowHeight < initBallHeight`

**If all three conditions above are fulfilled, return a positive integer,
otherwise return `-1`**

## Note:

The ball can only be seen if the height of the rebounding ball is strictly
greater than the window parameter.
Examples:

```
h = 3, bounce = 0.66, window = 1.5, result is 3

h = 3, bounce = 1, window = 1.5, result is -1 (condition 2 is not fulfilled) 
```

