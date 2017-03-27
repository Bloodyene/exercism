using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> keep = new List<T>();
        foreach (var i in collection)
        {
            if (predicate(i))
            {
                keep.Add(i);
            }
        }
        return keep;
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        List<T> discard = new List<T>();
        foreach (var i in collection)
        {
            if (!predicate(i))
            {
                discard.Add(i);
            }
        }
        return discard;
    }
}