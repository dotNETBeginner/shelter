using System;

namespace Задание_1__лаба_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя, возраст, ID, и дату рождения гражданина. *Дату через */* ");
            string[] s = Console.ReadLine().Split(" ");

            IPerson somePersone = new Citizen(s[0], int.Parse(s[1]),s[2],s[3]);
            somePersone.Display();
        }
    }
}
