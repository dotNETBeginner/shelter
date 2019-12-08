using System;
using System.Collections.Generic;
using System.Linq;
namespace Задание_11_лаба_15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> someStudents = new List<Student>();
            List<StudentsSpeciality> someStudentSpecialiites = new List<StudentsSpeciality>();

            string[] command = { "" };

            while (command[0] != "Students")
            {
                command = Console.ReadLine().Split(" ");

                if (command.Length == 3)
                { someStudentSpecialiites.Add(new StudentsSpeciality($"{command[0]} {command[1]}", command[2])); }

            }

            while(command[0] != "END")
            {
                command = Console.ReadLine().Split(" ");

                if (command.Length == 3)
                { someStudents.Add(new Student(command[0], $"{command[1]} {command[2]}")); }
            }

            var JoinedStudents = from st in someStudents
                                 join s in someStudentSpecialiites on st.FacNum equals s.FacNum
                                 orderby st.Name
                                 select new { Name = st.Name, FacNum = st.FacNum, SpecialityName = s.SpecialityName};

            foreach(var item in JoinedStudents)
            { Console.WriteLine($"{item.Name} {item.FacNum} {item.SpecialityName}"); }

        }
    }
}
