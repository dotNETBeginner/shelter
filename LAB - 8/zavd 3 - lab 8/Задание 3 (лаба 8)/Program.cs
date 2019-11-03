using System;

namespace Задание_3__лаба_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input height and width of rectangle");
            string[] s = Console.ReadLine().Split(" ");

            Rectangle someRectangle = new Rectangle(double.Parse(s[0]), double.Parse(s[1]));

            Console.WriteLine("Input radius of Circle");
            s = Console.ReadLine().Split(" ");

            Circle someCircle = new Circle(double.Parse(s[0]));

            Console.WriteLine(someRectangle.Draw());
            Console.WriteLine($"Area - {someRectangle.CalculateArea()}");
            Console.WriteLine($"Perimeter - {someRectangle.CalculatePerimeter()}");

            Console.WriteLine(someCircle.Draw());
            Console.WriteLine($"Area - {someCircle.CalculateArea()}");
            Console.WriteLine($"Perimeter - {someCircle.CalculatePerimeter()}");
        }
    }
}
