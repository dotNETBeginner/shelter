using System;
using System.Collections.Generic;
using System.Text;

namespace _8_задание_9_лаба
{
    class Box<T> where T : IComparable
    {
        T[] SomeProps;

        public Box() { SomeProps = new T[0]; }

        public void Add(T element)
        {
            int n = SomeProps.Length;

            n++;
            Array.Resize(ref SomeProps, n);

            for (int i = n - 1; i < n; i++)
            { SomeProps[i] = element; }
        }

        public void Remove(int indx)
        {
            int n = SomeProps.Length;

            for (int i = 0; i < n; i++)
            {
                if (i == indx)
                {
                    for (int j = i; j < n - 1; j++)
                        SomeProps[j] = SomeProps[j + 1];
                    n--;
                    Array.Resize(ref SomeProps, n);
                }
            }
        }

        public bool Contains(T element)
        {
            bool IsContains = false;

            for (int i = 0; i < SomeProps.Length; i++)
            {
                if (element.CompareTo(SomeProps[i]) == 0)
                { IsContains = true; }
            }

            return IsContains;
        }

        public void Swap(int indx1, int indx2)
        {
            T t = SomeProps[indx1];
            SomeProps[indx1] = SomeProps[indx2];
            SomeProps[indx2] = t;
        }

        public void Greater(T element)
        {
            int c = 0;
            for (int i = 0; i < SomeProps.Length; i++)
            {
                if (element.CompareTo(SomeProps[i]) < 0)
                { c++; }
            }

            Console.WriteLine(c);
        }

        public void Max()
        {
            T max = SomeProps[0];
            for (int i = 0; i < SomeProps.Length; i++)
            {
                if (max.CompareTo(SomeProps[i]) < 0)
                { max = SomeProps[i]; }
            }

            Console.WriteLine(max);
        }

        public void Min()
        {
            T min = SomeProps[0];
            for (int i = 0; i < SomeProps.Length; i++)
            {
                if (min.CompareTo(SomeProps[i]) > 0)
                { min = SomeProps[i]; }
            }

            Console.WriteLine(min);
        }

        public void Sort()
        {
            for(int i=0;i<SomeProps.Length;i++)
            {
                for(int j=i+1;j<SomeProps.Length;j++)
                {
                    if (SomeProps[i].CompareTo(SomeProps[j]) > 0)
                    {
                        T t = SomeProps[i];
                        SomeProps[i] = SomeProps[j];
                        SomeProps[j] = t;
                    }
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < SomeProps.Length; i++)
            { Console.WriteLine(SomeProps[i]); }
        }
    }
}
