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

            List<Box<string>> someBox = new List<Box<string>>();

            string s;

            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();

                Box<string> t = new Box<string>(s);
                someBox.Add(t);
            }

            for (int i = 0; i < someBox.Count; i++)
            { Console.WriteLine(someBox[i].ToString()); }

            Console.Read();
        }
    }
}