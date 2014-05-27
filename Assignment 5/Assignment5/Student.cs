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
        //static field for the last generated student ID
        private static int _LastUsedID = 20140001;

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        #endregion

        #region Constructors
        public Student()
        {
            _LastUsedID++;
            Id = _LastUsedID;
        }

        public Student(string name, string phone): this()
        {
            Name = name;
            PhoneNumber = phone;
        }
        #endregion

        #region Methods
        public virtual void DisplayStudent()
        {
            Console.Write("ID: {2} | Name: {0} | Phone: {1}", Name, PhoneNumber, Id);
        }
        #endregion
    }
}
