using System;
using System.Collections.Generic;
using System.Text;

namespace задание_9_лаба_15
{
    class Student
    {
        public string FacultyName { get; set; }
        public int[] Mark { get; set; }

        public Student(string facultyName, int[] mark)
        {
            FacultyName = facultyName;

            Mark = new int[mark.Length];

            for (int i = 0; i < Mark.Length; i++)
            { Mark[i] = mark[i]; }
        }

        public void Display()
        {
            for (int i = 0; i < Mark.Length; i++)
            { Console.Write($"{Mark[i]} "); }
            Console.WriteLine();
        }
    }
}

