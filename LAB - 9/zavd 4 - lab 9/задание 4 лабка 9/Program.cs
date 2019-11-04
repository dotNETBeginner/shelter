using System;

namespace задание_3_лаба_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int s;
            int[] bS = new int[n];

            for (int i = 0; i < n; i++)
            {
                s = int.Parse(Console.ReadLine());
                bS[i] = s;
            }

            Box<int> someBox = new Box<int>(n, bS);

            string[] command = Console.ReadLine().Split(" ");

            Swap<int>(someBox, int.Parse(command[0]), int.Parse(command[1]));
        }

        public static void Swap<T>(Box<T> Props, int i, int j)
        {
            T t = Props.SomeProps[i];
            Props.SomeProps[i] = Props.SomeProps[j];
            Props.SomeProps[j] = t;

            Props.Display();
        }
    }
}
