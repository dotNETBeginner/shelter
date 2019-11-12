using System;

namespace задание_4_лаба_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" ");

            int[] stones = new int[command.Length];

            for(int i=0; i<stones.Length;i++)
            { stones[i] = int.Parse(command[i]); }

            Lake someLake = new Lake(stones);

            foreach(int stone in someLake.GetEnumerator())
            { Console.Write(stone + " "); }
        }
    }
}
