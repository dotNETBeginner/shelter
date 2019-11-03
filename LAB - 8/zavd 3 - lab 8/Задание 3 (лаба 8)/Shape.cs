using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3__лаба_8_
{
    abstract class Shape
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string Draw()
        { return ""; }
    }
}
