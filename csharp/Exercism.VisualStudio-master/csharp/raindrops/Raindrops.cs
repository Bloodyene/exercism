using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string answer = "";
        if (number % 3 == 0)
        {
            answer += "Pling";
        }
        if (number % 5 == 0)
        {
            answer += "Plang";
        }
        if (number % 7 == 0)
        {
            answer += "Plong";
        }
        if (answer.Length == 0)
        {
            answer = number.ToString();
        }
        return answer;
    }
}