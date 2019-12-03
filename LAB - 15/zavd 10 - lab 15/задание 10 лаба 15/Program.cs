using System;
using System.Linq;
using System.Collections.Generic;

namespace задание_10_лаба_15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> somePersons = new List<Person>();

            string[] command = { "" };

            while(command[0] != "END")
            {
                command = Console.ReadLine().Split(" ");

                if (command.Length == 3)
                { somePersons.Add(new Person(command[0], command[1],int.Parse(command[2]))); }
            }

            var sortedPersons = somePersons.OrderBy(s => s.GroupName);

            var personsGroup = from p in sortedPersons
                               group p by p.GroupName;

            foreach(IGrouping<int,Person> p in personsGroup)
            {
                Console.Write($"{p.Key} - ");
                foreach(var g in p)
                { Console.Write($"{g.Name} {g.SecondName}, "); }
                Console.WriteLine();
            }

        }
    }
}
