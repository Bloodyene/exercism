using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.rna_transcription
{
    class Complement
    {
        public static string OfDna(string dna)
        {
            string rna = "";
            foreach (char i in dna)
            {
                if (i == 'G')
                {
                    rna += "C";
                }
                if (i == 'C')
                {
                    rna += "G";
                }
                if (i == 'T')
                {
                    rna += "A";
                }
                if (i == 'A')
                {
                    rna += "U";
                }
            }
            return rna;
        }
    }
}
