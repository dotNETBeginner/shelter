using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_5_лаба_9
{
    class Box<T> where T : IComparable

    {
        List<T> SomeProps = new List<T>();

        public Box(T[] bS) 
        {
            for(int i=0;i<bS.Length;i++)
            {
                SomeProps.Add(bS[i]);
            }
        }

        public int CompareValues(T[] someValue)
        {
            int counter = 0;
            
            for(int i=0;i<SomeProps.Count;i++)
            {
                for(int j=0;j<someValue.Length;j++)
                { 
                if(someValue[j].CompareTo(SomeProps[i]) < 0)
                    {
                        counter++;
                        break;
                    }
                }
             }

            return counter;
        }

    }
}
