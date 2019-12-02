
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_задание_лаба_15
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public Student(string firstNane, string secondName)
        {
            FirstName = firstNane;
            SecondName = secondName;
        }

        public void Display() => Console.WriteLine($"{FirstName} {SecondName}");
    }
}
