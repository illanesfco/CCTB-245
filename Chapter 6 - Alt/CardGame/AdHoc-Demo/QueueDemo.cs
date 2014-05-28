using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.AdHoc_Demo
{
    class QueueDemo
    {
        #region Methods
        public void Run()
        {
            Queue<string> items = new Queue<string>();
            FillWithData(items);
            EmptyAndDisplay(items);
        }

        private void FillWithData(Queue<string> items)
        {
            items.Enqueue("First"); // adding to the end of the queue
            items.Enqueue("Second");
            items.Enqueue("Third");
            items.Enqueue("Fourth");
        }

        private void EmptyAndDisplay(Queue<string> data)
        {
            Console.WriteLine("There are " + data.Count + " items in the queue:");
            foreach (string item in data)
            {
                Console.WriteLine(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("... now emptying data...");
            while (data.Count > 0)
            {
                Console.WriteLine(data.Dequeue());
            }
            Console.WriteLine();
        }
        #endregion
    }
}
