using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string input2 = input.ToUpper();
        int counter = 0;
        foreach (var item in Enumerable.Range(65,26))
        {
            if (input2.Contains(((char)item).ToString()))
            {
                counter++;
            }
        }
        if (counter == 26)
        {
            return true;
        }
        return false;
    }
}
