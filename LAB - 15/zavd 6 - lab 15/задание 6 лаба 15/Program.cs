using System;
using System.Linq;
using System.Collections.Generic;

namespace задание_6_лаба_15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> someStudent = new List<Student>();

            string[] command = { "" };

            while (command[0] != "END")
            {
                command = Console.ReadLine().Split(" ");

                if (command.Length == 3)
                { someStudent.Add(new Student(command[0], command[1], command[2])); }
            }

            var selectedStudent = from s in someStudent
                                  where s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592")
                                  select s;

            foreach (Student s in selectedStudent)
            { s.Display(); }
        }
    }
}