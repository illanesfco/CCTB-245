using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    abstract class AbstractCar : AbstractVehicle
    {
        #region overrided methods
        public override void ListFeatures()
        {
            SteeringWheel();
            GasPedal();
            Brakes();
        }

        public override void DisplayName()
        {
            Console.WriteLine(Name);
        }
        #endregion

        abstract public string Name { get; set; }

    }
}
