using System;
using System.Collections.Generic;
namespace Задание_3_лаба_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensionSizes = Console.ReadLine().Split(" ");

            int x = int.Parse(dimensionSizes[0]);
            int y = int.Parse(dimensionSizes[1]);

            int[,] matrix = new int[x, y];

            int value = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = value++;
                }
            }
            
            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                string[] aCommand = command.Split(" ");
                Ivo ivo = new Ivo(int.Parse(aCommand[0]), int.Parse(aCommand[1]));

                aCommand = Console.ReadLine().Split(" ");
                Evil evil = new Evil(int.Parse(aCommand[0]), int.Parse(aCommand[1]));

                evil.Move(matrix);
                ivo.Move(matrix);

                command = Console.ReadLine();
            }

            Console.WriteLine(Ivo.Sum);

        }
    }
}