using System;

namespace Задание_1_лаба_3_
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

            Person p1 = new Person(age,name); //Инициализация с помощью конструктора
            Person p2 = new Person();
            p2.Age = 18;              //Инициализация без помощи конструктора, или "вручную"
            p2.Name = "Vasyl";        //
            Person p3 = new Person(19,"Lena"); //строка 16
            p1.printInfo(); //Вывод информации о персонах
            p2.printInfo(); //
            p3.printInfo(); //
        }
    }
}
