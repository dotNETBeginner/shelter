using System;
using System.Collections.Generic;
using System.Text;

namespace задание_7_лаба_15
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int[] Mark { get; set; }

        public Student(string firstNane, string secondName, int[] mark)
        {
            FirstName = firstNane;
            SecondName = secondName;

            Mark = new int[mark.Length];

            for(int i = 0; i < Mark.Length; i++)
            { Mark[i] = mark[i]; }
        }

        public void Display() => Console.WriteLine($"{FirstName} {SecondName}");
    }
}
