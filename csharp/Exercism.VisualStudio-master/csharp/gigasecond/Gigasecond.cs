using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.gigasecond
{
    class Gigasecond
    {
        public static DateTime Date(DateTime date)
        {
            return date.Add(new TimeSpan(0, 0, 1000000000));
        }
    }
}
