using System;
using System.Collections.Generic;
using System.Text;

namespace задание_6_лаба_10
{
    class AgeComparer : IComparer<Person>
    {
       public int Compare(Person a, Person b)
        {
            if (a.Age == b.Age)
            { return 0; }
            else if (a.Age > b.Age)
            { return 1; }
            else
            { return -1; }
            
        }
    }
}
