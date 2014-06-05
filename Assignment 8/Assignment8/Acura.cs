using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Acura : AbstractCar, IGPS, ICruiseControl
    {

        public override string Name { get; set; }

        public Acura()
        {
            Name = "Acura Car";
        }

        #region overrided methods
        public override void ListFeatures()
        {
            base.ListFeatures();
            GPS();
            CruiseControl();

        }
        #endregion

        #region methods inherited from interface
        public void GPS()
        {
            Console.WriteLine("Vehicle has GPS.");
        }

        public void CruiseControl()
        {
            Console.WriteLine("Vehicle has Cruise Control.");
        }
        #endregion
    }
}
