using System;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a size of array");
            string[] s1 = Console.ReadLine().Split(" ");
            int x = int.Parse(s1[0]);
            int y = int.Parse(s1[1]);

            int[,] matrix = new int[x, y];

            int value = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++) { matrix[i, j] = value++; ; }
            }

            string command = " ";
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                Console.WriteLine("Input coordinates of Ivo");
                string[] ivoS = Console.ReadLine().Split(" ");
                Console.WriteLine("Input coordinates of Evil");
                string[] evil = Console.ReadLine().Split(" ");
                int xE = int.Parse(evil[0]);
                int yE = int.Parse(evil[1]);

                Console.WriteLine(matrix[xE,yE]);
                while (xE >= 0 && yE >= 0)
                {
                    if ( xE < matrix.GetLength(0) &&  yE < matrix.GetLength(1)) { matrix[xE, yE] = 0;}

                    xE--;
                    yE--;
                }

                int xI = int.Parse(ivoS[0]);
                int yI = int.Parse(ivoS[1]);

                Console.WriteLine(matrix[xI, yI]);

                while (xI >= 0 && yI < matrix.GetLength(1))
                {
                    if (xI < matrix.GetLength(0) && yI >= 0 )
                        sum += matrix[xI, yI];

                    yI++;
                    xI--;
                }
                Console.WriteLine("Write a command or skip it with help of Enter");
                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }
    }
}
