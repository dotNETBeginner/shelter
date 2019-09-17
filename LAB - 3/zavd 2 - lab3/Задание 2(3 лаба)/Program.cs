using System;

namespace Задание_2_3_лаба_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.WriteLine("Введите ваше имя.");
            name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст.");
            age = int.Parse(Console.ReadLine());

            Person p1 = new Person(age, name); //Сработает 3 конструктор
            Person p2 = new Person(); //Сработает 1 конструктор
            Person p3 = new Person(19); //Сработает 2 конструктор
            p1.printInfo(); //Вывод информации о персонах
            p2.printInfo(); //
            p3.printInfo(); //
        }
    }
}
