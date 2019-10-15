using System;

namespace Задание_1_лаба_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input name and age of Person.");
            string[] s = Console.ReadLine().Split(" ");

            Person somePerson = new Person(s[0],int.Parse(s[1]));

            Console.WriteLine("Input name and age of Child.");
             s = Console.ReadLine().Split(" ");

            Child someChild = new Child(s[0],int.Parse(s[1]));

            Console.WriteLine(somePerson.ToString());
            Console.WriteLine(someChild.ToString());
        }
    }
}
