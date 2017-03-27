using System;

public static class Hamming
{
    public static int Compute(string firstStrand, string secondStrand)
    {
        int counter = 0;
        if (firstStrand.Length == secondStrand.Length)
        {
            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i])
                {
                    counter++;
                }
            }
            return counter;
        }
        throw new Exception("Strands have different lenghts.");
    }
}