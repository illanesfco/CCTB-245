using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.AdHoc_Demo
{
    class StackDemo
    {
        #region Methods
        public void Run()
        {
            Stack<string> items = new Stack<string>();
            FillWithData(items);
            EmptyAndDisplay(items);
        }

        private void FillWithData(Stack<string> items)
        {
            items.Push("First"); // adding to the end of the queue
            items.Push("Second");
            items.Push("Third");
            items.Push("Fourth");
        }

        private void EmptyAndDisplay(Stack<string> data)
        {
            Console.WriteLine("There are " + data.Count + " items in the stack:");
            foreach (string item in data)
            {
                Console.WriteLine(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("... now emptying data...");
            while (data.Count > 0)
            {
                Console.WriteLine(data.Pop());
            }
            Console.WriteLine();
        }
        #endregion
    }
}
