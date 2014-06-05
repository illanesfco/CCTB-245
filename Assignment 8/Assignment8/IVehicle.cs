using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public interface IVehicle
    {
        #region methods

        void SteeringWheel();
        void GasPedal();
        void Brakes();

        #endregion
    }
}
