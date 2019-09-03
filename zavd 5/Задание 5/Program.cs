using System;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, average;
            Console.WriteLine("Введите 3 числа \n");
            a=Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            average = (a + b + c) / 3.0f;
            Console.WriteLine(average);
        }
    }
}
