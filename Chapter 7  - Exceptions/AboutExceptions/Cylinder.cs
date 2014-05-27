using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutExceptions
{
    class Cylinder
    {
        #region Properties
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Volume
        {
            get
            {
                double result = Math.PI * Radius * Radius * Height;
                return result;
            }

        }
        #endregion

        #region Constructors
        public Cylinder(double radius, double height)
        {
            //Basic Validation
            if (radius <= 0)
                throw new ArgumentException("A cylinder must have a radius greater than zero.");
            if (height <= 0)
                throw new ArgumentException("A cylinder must have a radius greater than zero.");
            Radius = radius;
            Height = height;
        }
        #endregion

        #region Method
        public static Cylinder operator +(Cylinder leftSide, Cylinder rightSide) //overload the + operator to allow the "addition" (stacking) of cylinders
        {
            //We cannot combine cylinders with different radii
            if (leftSide.Radius != rightSide.Radius)
                throw new NotSupportedException("Cannot add cylinders with different radius values");
            else
            {
                Cylinder result = new Cylinder(leftSide.Radius, leftSide.Height + rightSide.Height);
                return result;
            }
        }
        #endregion

    }
}
