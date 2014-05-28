using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    class Fraction
    {
        #region Properties
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        #endregion

        #region Constructors
        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        #endregion

        #region Methods
        public static Fraction operator +(Fraction first, Fraction second)
        {
            Fraction newFraction = new Fraction(first.Numerator, first.Denominator);
            newFraction.Numerator = newFraction.Numerator * second.Denominator + second.Numerator * newFraction.Denominator;
            newFraction.Denominator = newFraction.Denominator * second.Denominator;
            return newFraction;
        }

        public override string ToString()
        {
            return Numerator.ToString() + "/" + Denominator.ToString();
        }
        #endregion
    }
}
