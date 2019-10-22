using System;

namespace Задание_1__лаба_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя и возраст гражданина");
            string[] s = Console.ReadLine().Split(" ");

            IPerson somePersone = new Citizen(s[0], int.Parse(s[1]));
            somePersone.Display();
        }
    }
}
