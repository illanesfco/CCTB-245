using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "fran";
            Console.WriteLine("Name is {0} before", myName);
            myName = myName.UppercaseFirst();
            Console.WriteLine("Name is {0} after", myName);
        }
    }
}
