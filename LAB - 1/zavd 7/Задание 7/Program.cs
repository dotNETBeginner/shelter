using System;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, lastDigit;
            Console.WriteLine("Введите n");
            n = int.Parse(Console.ReadLine());
            lastDigit = n % 10;
            Console.Write($"Last digit of n is\n{lastDigit}");
        }
    }
}
