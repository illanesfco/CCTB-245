using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.AdHoc_Demo
{
    class ListDemo
    {
        #region Methods
        public void Run()
        {
            //Example of List<T> class and "generics"
            List<string> names; // declare a strongly-typed list of strings
            //names is a list that can only contain string objects
            names = new List<string>(); //instantiate the list - create an empty list
            FillWithData(names);
            Display(names);

            //Remove a name from the list
            names.Remove("Dan");
            Console.WriteLine("The name 'Dan' is removed...");
            Display(names);
        }

        private void FillWithData(List<string> list)
        {
            list.Add("Guido");
            list.Add("Dan");
            list.Add("Sally");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a name: ");
                list.Add(Console.ReadLine());
            }
        }

        private void Display(List<string> data)
        {
            Console.WriteLine("There are " + data.Count + " items in the list of names.");
            foreach (string item in data)
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine();
        }

        #endregion
    }
}
