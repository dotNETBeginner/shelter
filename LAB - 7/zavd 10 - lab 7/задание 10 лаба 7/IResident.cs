using System;
using System.Collections.Generic;
using System.Text;

namespace задание_10_лаба_7
{
    public interface IResident
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public void GetName();
    }
}
