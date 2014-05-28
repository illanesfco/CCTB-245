using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.AdHoc_Demo
{
    class ArrayDemo
    {
        #region Methods
        public void Run()
        {
            // Declare an array reference variable
            int[] myInfo;
            // Create the actual array of 5 integers
            myInfo = new int[5];

            FillWithRandom(myInfo);
            Display(myInfo);

            //How could I sort an array of integers?
            Array.Sort(myInfo); //faster way of sorting than one I could code
            Display(myInfo);

            //change the data
            FillWithRandom(myInfo);
            Display(myInfo);
            //TODO: Demo sorting arrays with .OrderBy() extension method
        }

        private void Display(int[] data)
        {
            // TODO: Code to show the size of the array and each value in the array
            Console.WriteLine("The array has " + data.Length + " elements: ");
            foreach (int item in data) // forward-only for loop through all elements
            {
                Console.WriteLine("\t" + item);
            }
            Console.WriteLine();
        }

        private void FillWithRandom(int[] array)
        {
            Random rnd = new Random(); // this object is a random-number generator
            //populate the array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100); // generate a random number between 1 and 99 as i-th element of the array 
                // for reference only, generates a random number between 0 and 99, potentially useful for accessing a random element in the array
                // rnd.Next(100);
                // rnd.Next(array.Length);
            }
        }
        #endregion
    }
}
