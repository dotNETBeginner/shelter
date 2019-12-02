using System;
using System.Collections.Generic;
using System.Text;

namespace _3_задание_15_лаба
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public Student(string firstNane, string secondName, int age)
        {
            FirstName = firstNane;
            SecondName = secondName;
            Age = age;
        }

        public void Display() => Console.WriteLine($"{FirstName} {SecondName} {Age}");
    }
}

