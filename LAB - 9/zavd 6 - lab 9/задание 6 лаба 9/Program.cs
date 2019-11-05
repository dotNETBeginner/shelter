using System;
using System.Collections.Generic;
namespace задание_6_лаба_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double s;
            double[] bS = new double[n];

            for (int i = 0; i < n; i++)
            {
                s = double.Parse(Console.ReadLine());
                bS[i] = s;
            }

            Box<double> someBox = new Box<double>(bS);

            double[] S = new double[1];
            S[0] = double.Parse(Console.ReadLine());

            Console.WriteLine(someBox.CompareValues(S));
        }
    }
}