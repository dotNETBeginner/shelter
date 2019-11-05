using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_10_лаба_9
{
    class Tuple<T,J>
    {
        public T Item1{ get ;set; }

        public J Item2 { get; set; }

        public Tuple()
        { }

        public void Add(T a, J b)
        {
            Item1 = a;
            Item2 = b;
        }

        public void Display()
        {
            Console.WriteLine($"{Item1}  ->  {Item2}");
        }
    }
}
