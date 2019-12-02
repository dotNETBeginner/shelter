using System;
using System.Linq;
using System.Collections.Generic;

namespace _3_задание_15_лаба
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
                { someStudent.Add(new Student(command[0], command[1], int.Parse(command[2]))); }
            }

            var selectedStudents = from s in someStudent
                                   where s.Age >= 18 && s.Age <= 24
                                   select s;

            foreach(Student s in selectedStudents)
            { s.Display(); }
        }
    }
}
