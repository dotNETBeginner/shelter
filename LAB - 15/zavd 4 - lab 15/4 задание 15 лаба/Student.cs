using System;
using System.Collections.Generic;
using System.Text;

namespace _4_задание_15_лаба
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public Student(string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
        }

        public void Display() => Console.WriteLine($"{FirstName} {SecondName}");
    }
}


