using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int To(IEnumerable<int> multiples, int max)
    {
        List<int> list = new List<int>();
        foreach (var item in multiples)
        {
            int a = item;
            do
            {
                if (a<max)
                {
                    if (!list.Contains(a))
                    {
                        list.Add(a);
                    }
                }
                a += item;
            } while (a < max);
        }
        int sum = 0;
        foreach (var item in list)
        {
            sum += item;
        }
        return sum;
    }
}