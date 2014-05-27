using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            DayTimeStudent day = new DayTimeStudent("Francisco", "403-554-1491", "S18", "HP2298");
            day.DisplayStudent();
            NightTimeStudent night = new NightTimeStudent("Javier", "403-149-1554", "WB122", "C#");
            night.DisplayStudent();
        }
    }
}
