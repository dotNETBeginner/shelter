using System;

namespace Задание_3_лаба_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Имя и возраст курицы.");
            string[] s = Console.ReadLine().Split(" ");

            Chicken someChiken = new Chicken(s[0],int.Parse(s[1]));

            someChiken.printInfo();
        }
    }
}
