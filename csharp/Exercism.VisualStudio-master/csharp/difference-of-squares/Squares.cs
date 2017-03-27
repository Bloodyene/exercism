using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.difference_of_squares
{
    class Squares
    {
        public int maxNumber;
        public Squares(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            maxNumber = number;
        }

        public int SumOfSquares()
        {
            int sum = 0;
            foreach (var i in Enumerable.Range(1,maxNumber))
            {
                sum += i * i;
            }
            return sum;
        }
        public int SquareOfSums()
        {
            int sum = 0;
            foreach (var i in Enumerable.Range(1,maxNumber))
            {
                sum += i;
            }
            return sum * sum;
        }
        public int DifferenceOfSquares()
        {
            return SquareOfSums() - SumOfSquares();
        }
    }
}
