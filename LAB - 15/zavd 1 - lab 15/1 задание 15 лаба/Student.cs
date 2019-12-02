using System;
using System.Collections.Generic;
using System.Text;

namespace _1_задание_15_лаба
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int GroupName { get; set; }

        public Student(string firstNane, string secondName, int groupName)
        {
            FirstName = firstNane;
            SecondName = secondName;
            GroupName = groupName;
        }

        public void Display() => Console.WriteLine($"{FirstName} {SecondName}");
    }
}
