using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.bob
{
    class Bob
    {
        public static string Hey(string t)
        {
            string text = "";
            int upperCounter = 0;
            foreach (var i in t)
            {
                if (!char.IsWhiteSpace(i))
                {
                    text += i;
                    if (char.IsUpper(i))
                    {
                        upperCounter++;
                    }
                }
            }

            if (text.Length == 0)
            {
                return "Fine. Be that way!";
            }

            else if (upperCounter > text.Length/5)
            {
                return "Whoa, chill out!";
            }

            else if (text[text.Length - 1] == '?')
            {
                return "Sure.";
            }
            
            return "Whatever.";
        }
    }
}
