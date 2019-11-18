using System;
using System.Collections.Generic;
namespace задание_6_лаба_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> SortedSet1 = new List<Person>();
            List<Person> SortedSet2 = new List<Person>();

            AgeComparer ac = new AgeComparer();
            NameComparer nc = new NameComparer();

            int n = int.Parse(Console.ReadLine());

            string[] command = { "" };

            for(int i=0; i<n; i++)
            {
                command = Console.ReadLine().Split(" ");

                SortedSet1.Add(new Person(command[0],int.Parse(command[1])));
                SortedSet2.Add(new Person(command[0], int.Parse(command[1])));
            }

            SortedSet1.Sort(nc);
            SortedSet2.Sort(ac);

            for(int i=0;i<SortedSet1.Count;i++)
            { SortedSet1[i].Display(); }

            for (int i = 0; i < SortedSet2.Count; i++)
            { SortedSet2[i].Display(); }
        }
    }
}
