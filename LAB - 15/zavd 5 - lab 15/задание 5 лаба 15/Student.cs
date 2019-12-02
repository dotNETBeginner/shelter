using System;
using System.Collections.Generic;
using System.Text;

namespace задание_5_лаба_15
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }

        public Student(string firstNane, string secondName, string email)
        {
            FirstName = firstNane;
            SecondName = secondName;
            Email = email;
        }

        public void Display() => Console.WriteLine($"{FirstName} {SecondName}");
    }
}


