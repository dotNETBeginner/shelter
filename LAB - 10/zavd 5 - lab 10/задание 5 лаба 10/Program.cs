using System;
using System.Collections.Generic;
namespace задание_5_лаба_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> somePersons = new List<Person>();

            string[] command = Console.ReadLine().Split(" ");

            while(command[0] != "END")
            {
                somePersons.Add(new Person(command[0],int.Parse(command[1]),command[2]));

                command = Console.ReadLine().Split(" ");
            }

            int n = int.Parse(Console.ReadLine());

            int resultSum = 1;

            for(int i=0;i<somePersons.Count;i++)
            {
                if (i == n - 1)
                {
                    for (int j = 0; j < somePersons.Count; j++)
                    {
                        if(somePersons[j] != somePersons[i])
                        resultSum += somePersons[j].CompareTo(somePersons[i]);

                    }                
                }
            }

            if(resultSum - 1 == 0)
            { Console.WriteLine("No matches"); }
            else
            {
                Console.WriteLine($"{resultSum}  {somePersons.Count - resultSum}  {somePersons.Count}");
            }
        }
    }
}
