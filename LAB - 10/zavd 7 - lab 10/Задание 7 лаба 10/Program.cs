using System;
using System.Collections.Generic;
namespace Задание_7_лаба_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> sortedSet = new List<Person>();
            List<Person> hashSet = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            string[] command = { "" }; 

            for(int i=0; i<n; i++)
            {
                command = Console.ReadLine().Split(" ");

                sortedSet.Add(new Person(command[0],int.Parse(command[1])));
                hashSet.Add(new Person(command[0], int.Parse(command[1])));
            }

            for(int i=0; i<hashSet.Count; i++)
            {
                for(int j=0; j<hashSet.Count; j++)
                {
                    if (j != i)
                    {
                        if (hashSet[j].Equals(hashSet[i]))
                        { hashSet.Remove(hashSet[i]); }
                    }
                }
            }

            for (int i = 0; i < sortedSet.Count; i++)
            {
                for (int j = 0; j < sortedSet.Count; j++)
                {
                    if (j != i)
                    {
                        if (sortedSet[j].Equals(sortedSet[i]))
                        { sortedSet.Remove(sortedSet[i]); }
                    }
                }
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
