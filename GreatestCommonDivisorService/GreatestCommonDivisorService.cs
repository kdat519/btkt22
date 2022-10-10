namespace GreatestCommonDivisorService;
using System;

public class GreatestCommonDivisorService
{
    public static int GreatestCommonDivisor(int a, int b)
    {
        if (a == int.MinValue || b == int.MinValue)
        {
            throw new ArgumentOutOfRangeException($"The value must be an integer between {-int.MaxValue} and {int.MaxValue}");
        }
        b = Math.Abs(b);
        if (a == 0)
        {
            return b;
        }
        a = Math.Abs(a);
        return GreatestCommonDivisor(b % a, a);
    }
}