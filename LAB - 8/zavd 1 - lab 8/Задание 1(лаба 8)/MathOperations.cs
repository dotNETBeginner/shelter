using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1_лаба_8_
{
    class MathOperations
    {
        public MathOperations() { }

        public virtual int Add(int a, int b)
        { return a + b; }

        public virtual double Add(double a, double b, double c)
        { return a + b + c; }

        public virtual decimal Add(decimal a, decimal b, decimal c)
        { return a + b + c; }
    }
}
