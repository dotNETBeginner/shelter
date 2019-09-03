using System;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, average;
            Console.WriteLine("Введите 3 числа \n");
            a=int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            average = (a + b + c) / 3.0f;
            Console.WriteLine(average);
        }
    }
}
