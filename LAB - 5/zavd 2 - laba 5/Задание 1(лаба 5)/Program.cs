using System;

namespace Задание_1_лаба_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры фигуры в таком порядке - *Длинна  Ширина  Высота*");
            string[] s = Console.ReadLine().Split(" ");

            Figure someFigure = new Figure(float.Parse(s[0]), float.Parse(s[1]), float.Parse(s[2]));

            someFigure.findSomeProperties();
        }
    }
}
