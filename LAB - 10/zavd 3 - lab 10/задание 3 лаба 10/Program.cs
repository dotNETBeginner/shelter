using System;

namespace задание_3_лаба_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> someStack = new Stack<int>();

            string[] command = Console.ReadLine().Split(" ");

            if(command[0] == "Push" && command.Length > 1)
            {
                int j = 1;
                int[] s = new int[command.Length - 1];
                for(int i = 0; i < s.Length; i++)
                { s[i] = int.Parse(command[j]); j++; }
                someStack.Push(s);

            }

            while(command[0] != "END")
            {
                command = Console.ReadLine().Split(" ");
                if (command[0] == "Push" && command.Length > 1)
                {
                    int j = 1;
                    int[] s = new int[command.Length - 1];
                    for (int i = 0; i < s.Length; i++)
                    { s[i] = int.Parse(command[j]); j++; }
                    someStack.Push(s);
                }

                else if(command[0] == "Pop")
                { someStack.Pop(); }
            }

            foreach(int i in someStack.PrintAll())
            { Console.WriteLine(i); }
        }
    }
}
