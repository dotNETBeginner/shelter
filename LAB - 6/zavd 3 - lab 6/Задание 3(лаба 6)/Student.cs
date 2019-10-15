using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3_лаба_6_
{
    class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if(value.Length < 5 || value.Length > 10)
                { throw new ArgumentException("Invalid faculty number!"); }
                else { facultyNumber = value; }
            }
        }

        public Student(string firstName, string lastName, string facultyNumber)
            :base(firstName,lastName)
        {
            FacultyNumber = facultyNumber;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Faculty Number: {FacultyNumber}");
        }
    }
}
