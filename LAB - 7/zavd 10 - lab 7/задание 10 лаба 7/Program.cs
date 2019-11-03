using System;
using System.Collections.Generic;
namespace задание_10_лаба_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> someCitizens = new List<Citizen>();

            string[] s = Console.ReadLine().Split(" ");

            while(s[0] != "End")
            {
                Citizen t = new Citizen(s[0],s[1],int.Parse(s[2]));
                someCitizens.Add(t);

                s = Console.ReadLine().Split(" ");
            }

            for(int i=0;i<someCitizens.Count;i++)
            { someCitizens[i].Display(); }
        }
    }
}
