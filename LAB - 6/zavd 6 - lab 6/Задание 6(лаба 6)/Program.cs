using System;
using System.Collections.Generic;
namespace Задание_6_лаба_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First, input type of animal or command *Beast!*");
            string s1 = Console.ReadLine();
            string[] s2=s1.Split();

            List<Animal> someAnimals = new List<Animal>();

            while(s1!="Beast!")
            {
                Console.WriteLine("Input name, age, and gender of animal");
                s2 = Console.ReadLine().Split(" ");
                try
                {
                    Animal t = new Animal(s1, s2[0], int.Parse(s2[1]), s2[2]);
                    someAnimals.Add(t);
                }
                
                catch (IndexOutOfRangeException)
                { Console.WriteLine("Fields must have a value!"); }
                catch (InvalidInputException iie)
                { Console.WriteLine(iie.Message); }
                catch (EmptyFieldException efe)
                { Console.WriteLine(efe.Message); }
                catch (FormatException)
                { Console.WriteLine("Age field can`t be empty"); }

                Console.WriteLine("Input type of animal or command *Beast!*");
                s1 = Console.ReadLine();
            }

            for(int i=0;i<someAnimals.Count;i++)
            { someAnimals[i].CheckAndAddAnimal(); }
        }
    }
}
