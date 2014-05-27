using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program myApp = new Program();
                Cylinder first = myApp.PromptForCylinder(3);
                myApp.Display(first);
                Cylinder second = myApp.PromptForCylinder(1);
                myApp.Display(second);

                Cylinder combined = first + second;
                Console.WriteLine();
                Console.WriteLine("The combined volume is {0} ({0} = {1} + {2})", combined.Volume, first.Volume, second.Volume);

                // force an exception
                int zero = 0, five = 5;
                int impossible = five / zero;
                Console.WriteLine("This should never really appear. The above line is a problem/bug.");
                Console.WriteLine(impossible);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("Uh - oh... I tried adding cylinders, but all I got was this:");
                Console.WriteLine("\t" + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Bad data... " + ex.Message);
            }
            catch (Exception ex)
            {
                // The Exception class is the top (parent) class in the set of inherited Exception classes
                Console.WriteLine("That was totally unexpected...");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally //will run whether or not an exception was caught
            {
                Console.WriteLine("Goodbye...");
                Console.Read();
            }
        }

        // Instance (non-static) methods for my Program
        private void Display(Cylinder data)
        {
            Console.WriteLine("The {0}x{1} cylinder has a volume of {2}", data.Radius, data.Height, data.Volume);
        }

        private Cylinder PromptForCylinder()
        {
            Console.WriteLine("Please enter the data for the cylinder.");
            Console.Write("\tHeight: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("\tRadius: ");
            double r = double.Parse(Console.ReadLine());
            return new Cylinder(r, h);
        }

        private Cylinder PromptForCylinder(int retries)
        {
            Cylinder result = null;
            do
            {
                try
                {
                    result = PromptForCylinder();
                }
                catch(Exception ex) // any and all exceptions
                {
                    Console.WriteLine("error - " + ex.Message);
                    Console.WriteLine("You have " + retries + " attempts left...");
                    retries--;
                }
            }
            while (result == null && retries > 0);
            //Very last chance
            if (result == null)
                result = PromptForCylinder();
            return result;
        }

    }
}
