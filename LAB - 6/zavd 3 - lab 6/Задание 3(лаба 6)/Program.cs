using System;

namespace Задание_3_лаба_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input information about a student.");
                string[] s = Console.ReadLine().Split(" ");

                Student someStudent = new Student(s[0],s[1],s[2]);

                Console.WriteLine("Input information about worker.");
                s = Console.ReadLine().Split(" ");

                Worker someWorker = new Worker(s[0],s[1],float.Parse(s[2]),int.Parse(s[3]));

                someStudent.Display();
                Console.Write("\n\n\n");
                someWorker.Display();
            }
            catch (ArgumentException ae)
            { Console.WriteLine(ae.Message); }
        }
    }
}
