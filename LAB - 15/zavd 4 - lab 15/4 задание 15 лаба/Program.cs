using System;
using System.Linq;
using System.Collections.Generic;

namespace _4_задание_15_лаба
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

            var selectedStudents = someStudents.OrderBy(s=>s.SecondName).ThenByDescending(s=>s.FirstName);

            foreach (Student std in selectedStudents)
            { std.Display(); }
        }
    }
}
