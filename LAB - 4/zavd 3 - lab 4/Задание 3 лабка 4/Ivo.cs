using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3_лаба_4_
{
    public class Ivo : ICoordinable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static int Sum { get; set; }

        public Ivo(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int[,] someMatrix)
        {
            while (X >= 0 && Y < someMatrix.GetLength(1))
            {
                if (X >= 0 && X < someMatrix.GetLength(0) && Y >= 0 && Y < someMatrix.GetLength(1))
                {
                    Sum += someMatrix[X, Y];
                }

                Y++;
                X--;
            }
        }
    }
}
