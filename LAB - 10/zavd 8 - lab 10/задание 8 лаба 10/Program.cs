using System;
using System.Collections.Generic;
namespace задание_8_лаба_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Clinic> someClinics = new List<Clinic>();
            List<Pet> somePets = new List<Pet>();

            Console.WriteLine("Input number of comamnds");
            int n = int.Parse(Console.ReadLine());

            IsMoreThanThousand(n);

            string[] command = { "" };

            for(int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split(" ");

                if (command.Length == 5)
                {
                    if (command[0] == "Create" && command[1] == "Pet")
                    { somePets.Add(new Pet(command[2], int.Parse(command[3]), command[4])); }
                    else
                    { Console.WriteLine("Invalid Operation!"); }
                }

                else if (command.Length == 4)
                {
                    try
                    {
                        if (command[0] == "Create" && command[1] == "Clinic")
                        { someClinics.Add(new Clinic(command[2], int.Parse(command[3]))); }
                        else
                        { Console.WriteLine("Invalip Operation!"); }
                    }
                    catch(Exception em)
                    { Console.WriteLine(em.Message); }
                }

                else if (command.Length == 3)
                {
                    if(command[0] == "Add")
                    {
                        for(int j=0; j<someClinics.Count;j++)
                        {
                            if(command[2] == someClinics[j].Name)
                            {
                                for(int q = 0; q<somePets.Count;q++)
                                { 
                                    if(command[1] == somePets[q].Name)
                                    { Console.WriteLine(someClinics[j].Add(somePets[q].Name, somePets[q].Age, somePets[q].Kind)); }
                                }
                            }
                        }
                    }

                    else if (command[0] == "Print")
                    {
                        for (int j = 0; j < someClinics.Count; j++)
                        {
                            if (command[1] == someClinics[j].Name)
                            { someClinics[j].Print(int.Parse(command[2])); }
                        }
                    }
                }

                else if (command.Length == 2)
                {
                    if (command[0] == "Release")
                    {
                        for (int j = 0; j < someClinics.Count; j++)
                        {
                            if (command[1] == someClinics[j].Name)
                            { Console.WriteLine(someClinics[j].Release()); }
                        }
                    }

                    else if (command[0] == "HasEmptyRooms")
                    {
                        for (int j = 0; j < someClinics.Count; j++)
                        {
                            if (command[1] == someClinics[j].Name)
                            { Console.WriteLine(someClinics[j].HasEmptyRooms()); }
                        }
                    }

                    else if (command[0] == "Print")
                    {
                        for (int j = 0; j < someClinics.Count; j++)
                        {
                            if (command[1] == someClinics[j].Name)
                            { someClinics[j].Print(); }
                        }
                    }
                }

                else
                { Console.WriteLine("Invalid Operation"); }
            }

        }

        public static void IsMoreThanThousand(int n)
        {
            if(n > 1000)
            {
                while(n > 1000)
                {
                    Console.WriteLine("Number of command is more than 1000, input again!");
                    n = int.Parse(Console.ReadLine()); 
                }
            }
        }
    }
}
