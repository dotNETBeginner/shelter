using System;
using System.Collections;
namespace Задание_1_лаба_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> someBody = new ListyIterator<string>();

            string[] command = Console.ReadLine().Split(" ");

            if (command[0] == "Create" && command.Length > 1)
            { someBody.Create(command); }
            
            while(command[0] != "END")
            {
                command = Console.ReadLine().Split(" ");
                try
                {
                    if (command[0] == "Move")
                    { Console.WriteLine(someBody.Move()); }
                    else if (command[0] == "HasNext")
                    { Console.WriteLine(someBody.HasNext()); }
                    else if (command[0] == "Print")
                    { someBody.Print(); }
                    else if (command[0] == "PrintAll")
                    {
                       foreach(string item in someBody.PrintAll())
                        {
                            Console.Write(item + " ");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Operation!");
                }
            }
        }
    }
}
