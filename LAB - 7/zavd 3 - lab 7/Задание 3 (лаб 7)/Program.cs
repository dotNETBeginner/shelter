using System;

namespace Задание_3__лаб_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя водителя");
            string sname = Console.ReadLine();

            Ferrari someFerrari = new Ferrari(sname);
            someFerrari.Display();
        }
    }
}
