using System;
using System.Collections.Generic;
namespace Задание_5_лаба_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string s;
            string[] bS = new string[n];

            for(int i=0;i<n;i++)
            {
                s = Console.ReadLine();
                bS[i] = s;
            }

            Box<string> someBox = new Box<string>(bS);

            s = Console.ReadLine();

            string[] S = s.Split();

            Console.WriteLine(someBox.CompareValues(S)) ;
        }
    }
}
