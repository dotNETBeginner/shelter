using System;

namespace Задание_4_лаба_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество людей.");
            int n = int.Parse(Console.ReadLine());

            Team group = new Team(n);

            Console.WriteLine("Введите имя и возраст людей.");

            string[] names = new string[n];
            int[] ages = new int[n];

            for(int i = 0; i < n; i++) { names[i] = Console.ReadLine();ages[i] = int.Parse(Console.ReadLine()); }

            for(int i = 0; i < n; i++) {group.addMan(i,names,ages); }
            

            Console.WriteLine("-----------------------------------------");

            for (int i = 0; i < n; i++) { group.printMan(i); }

            Console.WriteLine("-----------------------------------------");

            group.findMoreThan30(n,group);

            Console.WriteLine("-----------------------------------------");
        }
    }
}
