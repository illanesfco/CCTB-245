﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Ford fordCar = new Ford();
            fordCar.DisplayName();
            fordCar.IsVehicle();
            fordCar.ListFeatures();
            Acura acuraCar = new Acura();
            acuraCar.DisplayName();
            acuraCar.IsVehicle();
            acuraCar.ListFeatures();
        }
    }
}
