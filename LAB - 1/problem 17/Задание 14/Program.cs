using System;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,n1=1;
            Console.WriteLine("Введите n");
            n = int.Parse(Console.ReadLine());
            for (int i=2;i<=n;i++)
                 n1*= i;
            n = n1;
            Console.Write($"n! - {n}");
        }
    }
}
