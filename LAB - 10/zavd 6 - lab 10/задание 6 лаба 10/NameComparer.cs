using System;
using System.Collections.Generic;
using System.Text;

namespace задание_6_лаба_10
{
    class NameComparer : IComparer<Person>
    {
        public int Compare(Person a, Person b)
        {
            if (a.Name.Length == b.Name.Length)
            {
                string sa, sb;

                sa = a.Name.ToLower();
                sb = b.Name.ToLower();

                if (sa[0] < sb[0])
                { return -1; }
                else if (sa[0] > sb[0])
                { return 1; }
                else
                { return 0; }
            }

            else if (a.Name.Length > b.Name.Length)
            { return 1; }
            else
            { return -1; }
        }
    }
}
