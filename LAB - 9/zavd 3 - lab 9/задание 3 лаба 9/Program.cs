using System;

namespace задание_3_лаба_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string s;
            string[] bS = new string[n];

            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                bS[i] += " " + s;
            }

            Box<string> someBox = new Box<string>(n, bS);

            bS = Console.ReadLine().Split(" ");

            Swap<string>(someBox,int.Parse(bS[0]), int.Parse(bS[1]));
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
