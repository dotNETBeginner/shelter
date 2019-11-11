using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1_лаба_10
{
    class ListyIterator <T>
    {
        public int currIndex { get; set; }
        public T[] someProps { get; set; }

        public ListyIterator() { }

        public bool Move()
        {
            if(HasNext())
            { currIndex++; return true; }
            else { return false; }
        }

        public bool HasNext()
        {
            if ((currIndex + 1) < someProps.Length)
            { return true; }
            else { return false; }
        }

        public void Print()
        {
            Console.WriteLine(someProps[currIndex]);
        }

        public void Create(T[] array)
        {
            int j = 1;
            someProps = new T[array.Length - 1];

            for (int i = 0; i < someProps.Length; i++)
            { someProps[i] = array[j]; j++; }

            currIndex = 0;
        }

        public IEnumerable<T> PrintAll()
        {
            foreach(T i in someProps)
            {
                yield return i;
            }
        }
    }
}
