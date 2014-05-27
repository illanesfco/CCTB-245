using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    public class Product
    {
        // Auto-Implemented Properties
        public int Id { get; set; } // default of 0
        public string Name { get; set; } // default of null

        //Constructors (defines the different ways to "make" the object
        public Product()
        {
            // empty body - let the properties' values be their defaults
        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Virtual Method - use when you intend subclasses to override the behaviour 
        public virtual void Purchase()
        {
            // Temp - just output to console
            Console.WriteLine("Product Purchase {0}", Name);
        }
    }
}
