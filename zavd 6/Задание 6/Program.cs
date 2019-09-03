using System;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, h, Area;
                Console.WriteLine("Введите а");
            a = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите b");
            b = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите h");
            h = float.Parse(Console.ReadLine());
            Area = ((a + b) / 2) * h;
            Console.WriteLine($"Площадь - {Area}");
        }
    }
}
