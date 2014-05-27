using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
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
            Radius = radius;
            Height = height;
        }
        #endregion

        #region Method
        public static Cylinder operator +(Cylinder leftSide, Cylinder rightSide) //overload the + operator to allow the "addition" (stacking) of cylinders
        {
            Cylinder result = new Cylinder(leftSide.Radius, leftSide.Height + rightSide.Height);
            return result;
        }
        #endregion

    }
}
