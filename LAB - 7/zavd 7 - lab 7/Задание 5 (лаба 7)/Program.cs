using System;
using System.Collections.Generic;
namespace Задание_5__лаба_7_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input digit of persons");
            int n = Convert.ToInt32(Console.ReadLine());

            List<Citizen> someCitizens = new List<Citizen>();
            List<Rebel> someRebels = new List<Rebel>();

            Console.WriteLine("Inpute name of persons, and their properties");
            string[] command = { " " };


            for (int i = 0; i < n; i++)
             {
                command = Console.ReadLine().Split(" ");

                    bool IsSamePerson = false;
                if (i >= 1)
                    {
                    for (int j = 0; j < someCitizens.Count; j++)
                    {
                        if (command[0] == someCitizens[j].Name)
                        {
                             Console.WriteLine("Person with this name is already exist!"); 
                            IsSamePerson = true;
                        }
                    }
                    }
                if (command.Length == 4)
                {
                    if (!IsSamePerson) { Citizen t = new Citizen(command[0], int.Parse(command[1]), command[2], command[3]); someCitizens.Add(t); }
                }

                IsSamePerson = false;

                    if (i >= 1)
                    {
                    for (int j = 0; j < someRebels.Count; j++)
                    {
                        if (command[0] == someRebels[j].Name)
                        {
                             Console.WriteLine("Person with this name is already exist!"); 
                            IsSamePerson = true;
                        }
                    }
                    }
                if (command.Length == 3)
                {
                    if (!IsSamePerson) { Rebel t = new Rebel(command[0], int.Parse(command[1]), command[2]); someRebels.Add(t); }
                }
            }
            Console.WriteLine("Inpute name if you wanna buy some Food, or inpur *End* to end the program");
            string sCommand = Console.ReadLine();

            int FoodSum = 0;

            while(sCommand!="End")
            {
                for(int i=0;i<someCitizens.Count;i++)
                {
                    if(sCommand == someCitizens[i].Name)
                    { someCitizens[i].BuyFood(); }
                }

                for (int i = 0; i < someRebels.Count; i++)
                {
                    if (sCommand == someRebels[i].Name)
                    { someRebels[i].BuyFood(); }
                }

                sCommand = Console.ReadLine();
            }

            for(int i=0;i<someCitizens.Count;i++)
            { FoodSum += someCitizens[i].Food; }

            for (int i = 0; i < someRebels.Count; i++)
            { FoodSum += someRebels[i].Food; }

            Console.WriteLine(FoodSum);
        }
        }
    }
