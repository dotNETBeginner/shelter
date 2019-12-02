using System;
using System.Linq;
using System.Collections.Generic;
namespace _1_задание_15_лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> someStudents = new List<Student>();

            string[] command = { "" };

            while(command[0] != "END")
            {
                command = Console.ReadLine().Split(" ");

                if (command.Length == 3)
                { someStudents.Add(new Student(command[0], command[1], int.Parse(command[2]))); }
            }


            var selectedStudents = from s in someStudents
                                   where s.GroupName == 2
                                   orderby s.FirstName
                                   select s;
            
            foreach(Student s in selectedStudents)
            { s.Display(); }
        }
    }
}
