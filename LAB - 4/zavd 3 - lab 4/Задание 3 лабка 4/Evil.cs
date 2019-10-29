using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3_лаба_4_
{
    public class Evil : ICoordinable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Evil(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int[,] someMatrix)
        {
            while (X >= 0 && Y >= 0)
            {
                if (X >= 0 && X < someMatrix.GetLength(0) && Y >= 0 && Y < someMatrix.GetLength(1))
                {
                    someMatrix[X, Y] = 0;
                }
                X--;
                Y--;
            }
        }
    }
}
