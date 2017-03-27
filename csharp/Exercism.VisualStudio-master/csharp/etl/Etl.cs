using System;
using System.Collections.Generic;

public static class ETL
{
    public static IDictionary<string, int> Transform(IDictionary<int, IList<string>> old)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        foreach (var i in old)
        {
            foreach (var j in i.Value)
            {
                result.Add(j.ToLower(), i.Key);
            }
        }
        return result;
    }
}