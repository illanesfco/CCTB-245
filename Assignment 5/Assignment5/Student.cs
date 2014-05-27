using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Student
    {
        #region Properties and Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        #endregion

        #region Methods
        public virtual void DisplayStudent()
        {
            Console.Write("Name: {0} | Phone: {1}", Name, PhoneNumber);
        }
        #endregion
    }
}
