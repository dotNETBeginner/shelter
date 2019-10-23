using System;
using System.Collections.Generic;
namespace Задание_5__лаба_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> someCitizens = new List<Citizen>();
            List<Robot> someRobots = new List<Robot>();
            List<Pet> somePets = new List<Pet>();

            BirthDateEvent evt = new BirthDateEvent();

            Console.WriteLine("Iput name of citizen and his ID,and his BirthDate, or model of robot and his ID ,or name of pet and his birthdate, or command *End*");
            string[] command = Console.ReadLine().Split(" ");
            
            while(command[0]!="End")
            {
                if(command[0] == "Robot") { Robot t = new Robot(command[0], command[1]); someRobots.Add(t); }
                else if(command[0] == "Citizen") { Citizen t = new Citizen(command[1], int.Parse(command[2]), command[3], command[4]); someCitizens.Add(t); }
                else if(command[0] == "Pet") { Pet t = new Pet(command[1], command[2]); somePets.Add(t); }
                else { Console.WriteLine("ERROR!"); }
                command = Console.ReadLine().Split(" ");
            }
            Console.WriteLine("Input year, to find date with that year");
            string someYear = Console.ReadLine();

            for(int i=0;i<someCitizens.Count;i++)
            {
                evt.findYear += someCitizens[i].FindYearInDate;
                evt.UserEvent(someYear);
                evt.findYear -= someCitizens[i].FindYearInDate;
            }

            for (int i = 0; i < somePets.Count; i++)
            {
                evt.findYear += somePets[i].FindYearInDate;
                evt.UserEvent(someYear);
                evt.findYear -= somePets[i].FindYearInDate;
            }
        }
    }
}
