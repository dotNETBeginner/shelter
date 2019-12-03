using System;
using System.Linq;
using System.Collections.Generic;

namespace задание_8_лаба_15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> someStudent = new List<Student>();

            string[] command = { "" };
            string[] marks = { "" };

            while (command[0] != "END")
            {
                command = Console.ReadLine().Split(" ");

                if (command[0] != "END")
                {
                    int[] intMarks = new int[command.Length - 2];
                    StringToInt(intMarks, command);

                    if (intMarks.Length + 2 == command.Length)
                    { someStudent.Add(new Student(command[0], command[1], intMarks)); }
                }

            }

            var selectedStudent = from s in someStudent
                                  where s.Mark.Count(s=>s <= 3) == 2
                                  select s;

            foreach (Student s in selectedStudent)
            { s.Display(); }

        }

        static void StringToInt(int[] a, string[] b)
        {
            int q = 2;
            for (int i = 0; i < a.Length; i++)
            { a[i] = int.Parse(b[q]); q++; }
        }

    }
}
