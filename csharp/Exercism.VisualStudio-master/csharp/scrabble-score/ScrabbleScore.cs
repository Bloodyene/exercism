using System;
using System.Collections.Generic;
using System.Linq;

public static class Scrabble
{
    public static int Score(string input)
    {
        if (input == null)
        {
            return 0;
        }
        Dictionary<List<string>, int> dic = new Dictionary<List<string>, int>();
        dic.Add(new List<string> { "A", "E", "I", "O", "U", "L", "N", "R", "S", "T" }, 1);
        dic.Add(new List<string> { "D", "G" }, 2);
        dic.Add(new List<string> { "B", "C", "M", "P" }, 3);
        dic.Add(new List<string> { "F", "H", "V", "W", "Y" }, 4);
        dic.Add(new List<string> { "K" }, 5);
        dic.Add(new List<string> { "J", "X" }, 8);
        dic.Add(new List<string> { "Q", "Z" }, 10);
        input = input.ToUpper();
        int sum = 0;
        foreach (var i in input)
        {
            foreach (var j in dic.Keys)
            {
                if (j.Contains(i.ToString()))
                {
                    sum += dic[j];
                }
            }
        }
        return sum;
    }
}
//A, E, I, O, U, L, N, R, S, T       1
//D, G                               2
//B, C, M, P                         3
//F, H, V, W, Y                      4
//K                                  5
//J, X                               8
//Q, Z                               10