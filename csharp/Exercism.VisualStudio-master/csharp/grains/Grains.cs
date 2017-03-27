using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        return (ulong)Math.Pow(2, n - 1);
    }

    public static ulong Total()
    {
        ulong sum = 0;
        for (int i = 0; i < 64; i++)
        {
            sum += Square(i + 1);
        }
        return sum;
    }
}