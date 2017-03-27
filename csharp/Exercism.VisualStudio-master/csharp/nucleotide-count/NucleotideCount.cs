using System;
using System.Collections.Generic;

public class DNA
{
    string sequence;
    public DNA(string sequence)
    {
        this.sequence = sequence;
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            IDictionary<char, int> counts = new Dictionary<char, int> { { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 } };
            foreach (var i in sequence)
            {
                counts[i]++;
            }
            return counts;
        }
    }

    public int Count(char nucleotide)
    {
        if (!(nucleotide == 'A' || nucleotide == 'T' || nucleotide == 'C' || nucleotide == 'G'))
        {
            throw new InvalidNucleotideException();
        }
        int counter = 0;
        foreach (var i in sequence)
        {
            if (i == nucleotide)
            {
                counter++;
            }
        }
        return counter;
    }
}

public class InvalidNucleotideException : Exception { }
