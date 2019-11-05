using System;
using System.Collections.Generic;
namespace _1_задание_9_лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input number of inpute lines");
            int n = int.Parse(Console.ReadLine());

            List<Box<int>> someBox = new List<Box<int>>();

            int s;

            for (int i = 0; i < n; i++)
            {
                s = int.Parse(Console.ReadLine());

                Box<int> t = new Box<int>(s);
                someBox.Add(t);
            }

            for (int i = 0; i < someBox.Count; i++)
            { Console.WriteLine(someBox[i].ToString()); }

            Console.Read();
        }
    }
}
