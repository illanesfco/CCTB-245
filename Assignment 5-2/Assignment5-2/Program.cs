using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction oneHalf = new Fraction(1, 2);
            Fraction oneQuarter = new Fraction(1, 4);
            Fraction sumFraction = oneHalf + oneQuarter;
            Console.WriteLine(oneHalf.ToString() + " + " + oneQuarter.ToString() + " = " + sumFraction.ToString());
        }
    }
}
