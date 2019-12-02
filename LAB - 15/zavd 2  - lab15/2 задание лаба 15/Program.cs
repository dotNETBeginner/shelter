using System;
using System.Linq;
using System.Collections.Generic;
namespace _2_задание_лаба_15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> someStudents = new List<Student>();

            string[] command = { "" };

            while (command[0] != "END")
            {
                command = Console.ReadLine().Split(" ");

                if (command.Length == 2)
                { someStudents.Add(new Student(command[0], command[1])); }
            }


            var selectedStudents = from s in someStudents
                                   where s.FirstName.First() < s.SecondName.First()
                                   select s;

            foreach (Student s in selectedStudents)
            { s.Display(); }
        }
    }
}
