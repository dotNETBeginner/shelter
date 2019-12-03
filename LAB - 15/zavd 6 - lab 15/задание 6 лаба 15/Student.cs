using System;
using System.Collections.Generic;
using System.Text;

namespace задание_6_лаба_15
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Phone { get; set; }

        public Student(string firstNane, string secondName, string phone)
        {
            FirstName = firstNane;
            SecondName = secondName;
            Phone = phone;
        }

        public void Display() => Console.WriteLine($"{FirstName} {SecondName}");
    }
}

