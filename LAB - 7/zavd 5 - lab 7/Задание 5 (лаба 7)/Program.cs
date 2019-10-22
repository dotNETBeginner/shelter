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

            Console.WriteLine("Iput name of citizen ot model of robot and his ID or command *End*");
            string[] command = Console.ReadLine().Split(" ");
            
            while(command[0]!="End")
            {
                if(command.Length == 2) { Robot t = new Robot(command[0], command[1]); someRobots.Add(t); }
                else if(command.Length == 3) { Citizen t = new Citizen(command[0], int.Parse(command[1]), command[2]); someCitizens.Add(t); }
                command = Console.ReadLine().Split(" ");
            }
            Console.WriteLine("Input last 3 numbers of ID than can be fake");
            string fakeIdNumber = Console.ReadLine();

            for(int i=0;i<someCitizens.Count;i++)
            { someCitizens[i].FindFakeId(fakeIdNumber); }

            for (int i = 0; i < someRobots.Count; i++)
            { someRobots[i].FindFakeId(fakeIdNumber); }
        }
    }
}
