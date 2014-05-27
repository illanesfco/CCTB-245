using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEssentials
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoInheritance();
            //DemoPolymorphism();
            DemoOperatorOverloading();
            
        }

        static void DemoOperatorOverloading()
        {
            Cylinder barrel = new Cylinder(5, 20);
            Console.WriteLine("The volume is " + barrel.Volume);

            Cylinder doubleBarrel = barrel + barrel;
            Console.WriteLine("The volume is " + doubleBarrel.Volume);
        }

        static void DemoInheritance()
        {
            // Use my store and look up a product
            Store myStore = new Store(1, "Best Store");
            Product myProduct = myStore.GetProduct(5);

            Console.WriteLine("Store is {0}, Product is {1}", myStore.Name, myProduct.Name);

            // Explore the Computer class
            // Intantiate an object of data type Computer
            Computer oldMachine = new Computer();
            oldMachine.CPU = "x86";
            oldMachine.OS = "Windows XP";
            oldMachine.Name = "HP 1234-x"; //some brand-name I bought
            oldMachine.Id = 25;

            // Instantiate a Laptop with an Initializer List
            Laptop newMachine = new Laptop()
            {
                Id = 77,
                Name = "HP 532-Y",
                CPU = "Athalon Tiger",
                OS = "Windows 10",
                MonitorSize = 27.5
            };

        }

        static void DemoPolymorphism()
        {
            Store otherstore = new Store(2, "Future Buy");
            Product myProduct = otherstore.GetProduct(5);
            myProduct.Purchase();

            Laptop myMac = new Laptop();
            myMac.Name = "Macbook Pro";
            myMac.Purchase();
        }
    }
}
