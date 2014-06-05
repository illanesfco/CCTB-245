using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Ford : AbstractCar
    {

        public override string Name { get; set; }

        public Ford()
        {
            Name = "Ford Car";
        }
    }
}
