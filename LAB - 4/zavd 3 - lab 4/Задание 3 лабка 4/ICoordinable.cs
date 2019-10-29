using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3_лаба_4_
{
    interface ICoordinable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Move(int[,] matrix);
    }
}
