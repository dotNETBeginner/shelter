using System;

namespace Задание_1_лаба_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations someOperations = new MathOperations();

            Console.WriteLine(someOperations.Add(2,3));
            Console.WriteLine(someOperations.Add(2.2, 3.3, 5.5));
            Console.WriteLine(someOperations.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
