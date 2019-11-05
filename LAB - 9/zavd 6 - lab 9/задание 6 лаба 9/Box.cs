using System;
using System.Collections.Generic;
using System.Text;

namespace задание_6_лаба_9
{
    class Box<T> where T : IComparable

    {
        List<T> SomeProps = new List<T>();

        public Box(T[] bS)
        {
            for (int i = 0; i < bS.Length; i++)
            {
                SomeProps.Add(bS[i]);
            }
        }

        public int CompareValues(T[] someValue)
        {
            int counter = 0;

            for (int i = 0; i < SomeProps.Count; i++)
            {
                    if (someValue[0].CompareTo(SomeProps[i]) < 0)
                    {
                        counter++;
                        continue;
                    }
            }

            return counter;
        }

    }
}
