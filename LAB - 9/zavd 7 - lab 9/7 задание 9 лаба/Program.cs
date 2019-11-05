using System;

namespace _7_задание_9_лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" ");

            Box<string> someBox = new Box<string>();

            while(command[0] != "END")
            {
                if(command[0] == "Add" && command.Length == 2)
                { someBox.Add(command[1]); }

                else if (command[0] == "Remove" && command.Length == 2)
                { someBox.Remove(int.Parse(command[1])); }

                else if (command[0] == "Contains" && command.Length == 2)
                { Console.WriteLine(someBox.Contains(command[1])); }

                else if (command[0] == "Swap" && command.Length == 3)
                { someBox.Swap(int.Parse(command[1]),int.Parse(command[2])); }

                else if (command[0] == "Greater" && command.Length == 2)
                { someBox.Greater(command[1]); }

                else if (command[0] == "Max" && command.Length == 1)
                { someBox.Max(); }

                else if (command[0] == "Min" && command.Length == 1)
                { someBox.Min(); }

                else if (command[0] == "Print" && command.Length == 1)
                { someBox.Display(); }

                else { Console.WriteLine("Invalid command!"); }

                command = Console.ReadLine().Split(" ");
            }

        }
    }
}
