using System;
using System.Collections.Generic;
using System.Text;

namespace задание_3_лаба_9
{
    class Box<T>
    {
        public T[] SomeProps { get; set; }

        public Box(int n, T[] someProps)
        {
            SomeProps = new T[n];

            for (int i = 0; i < someProps.Length; i++)
            { SomeProps[i] = someProps[i]; }
        }

        public void Display()
        {
            for(int i=0;i<SomeProps.Length;i++)
            { Console.WriteLine($"{SomeProps[i].GetType().FullName}  -  {SomeProps[i]}"); }
        }
    }
}