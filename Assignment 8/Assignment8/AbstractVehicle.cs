using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    abstract class AbstractVehicle : IVehicle
    {
        #region Methods implemented from IVehicle
        public void SteeringWheel()
        {
            Console.WriteLine("Vehicle has a steering wheel.");
        }

        public void GasPedal()
        {
            Console.WriteLine("Vehicle has a gas pedal.");
        }

        public void Brakes()
        {
            Console.WriteLine("Vehicle has brakes.");
        }
        #endregion

        #region abstract methods
        abstract public void ListFeatures();

        abstract public void DisplayName();
        #endregion

        public void IsVehicle()
        {
            Console.WriteLine("I am a vehicle");
        }
    }
}
