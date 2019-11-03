using System;
using System.Collections.Generic;
using System.Text;

namespace задание_10_лаба_7
{
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetName();
    }
}
