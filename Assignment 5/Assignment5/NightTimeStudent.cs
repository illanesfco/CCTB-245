using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class NightTimeStudent : Student
    {
        #region Properties and Fields
        public string RoomNumber { get; set; }
        public string CourseName { get; set; }
        #endregion

        #region Constrcutors
        public NightTimeStudent(int id, string name, string phone, string room, string course)
        {
            Id = id;
            Name = name;
            PhoneNumber = phone;
            RoomNumber = room;
            CourseName = course;
        }
        #endregion

        #region Methods
        public override void DisplayStudent()
        {
            Console.WriteLine("Name: {0} | Phone: {1} | Room Number: {2} | Course Name: {3}", Name, PhoneNumber, RoomNumber, CourseName);
        }
        #endregion

    }
}
