using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class DayTimeStudent : Student
    {
        #region Properties and Fields
        public string Section { get; set; }
        public string Locker { get; set; }
        #endregion

        #region Constructors
        public DayTimeStudent(string name, string phone, string sec, string locker) : base(name, phone)
            //inherit base (student) class paramters (name, phone)
        {
            Section = sec;
            Locker = locker;
        }
        #endregion

        #region Methods
        public override void DisplayStudent()
        {
            base.DisplayStudent();
            Console.WriteLine(" | Section: {0} | Locker: {1}", Section, Locker);
        }
        #endregion
    }
}
