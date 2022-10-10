namespace GreatestCommonDivisorService;
using System;

public class GreatestCommonDivisorService
{
    public static int GreatestCommonDivisor(int a, int b)
    {
        b = Math.Abs(b);
        if (a == 0)
        {
            return b;
        }
        a = Math.Abs(a);
        return GreatestCommonDivisor(b % a, a);
    }
}
