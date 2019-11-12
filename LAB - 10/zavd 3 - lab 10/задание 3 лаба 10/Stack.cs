using System;
using System.Collections.Generic;
using System.Text;

namespace задание_3_лаба_10
{
    class Stack<T>
    {
        private T[] someProps;
        public int CurrIndex { get; set; }
        public T[] SomeProps
        {
            get { return someProps; }
            set { someProps = value; } 
        }

        public Stack() { }

        public void Push(T[] array)
        {
            int n = 0;

            if(someProps != null)
            { n = someProps.Length;}

            for (int i = 0; i < array.Length; i++)
            {
                n++;
                Array.Resize(ref someProps,n);
                SomeProps[SomeProps.Length-1] = array[i];
            }
        }

        public void Pop()
        {
            int n = SomeProps.Length;

            if (n == 0)
            { Console.WriteLine("No elements"); }
            else
            {

                for (int i = 0; i < n; i++)
                {
                    if (i == (n - 1))
                    {
                        for (int j = i; j < n - 1; j++)
                            SomeProps[j] = SomeProps[j + 1];
                        n--;
                        Array.Resize(ref someProps, n);
                        break;
                    }
                }
            }
        }

        public IEnumerable<T> PrintAll()
        {
            for (int i = 0; i < 2; i++)
            {
                for(int j = someProps.Length-1; j >= 0; j--)
                { yield return someProps[j]; }
            }
        }
    }
}
