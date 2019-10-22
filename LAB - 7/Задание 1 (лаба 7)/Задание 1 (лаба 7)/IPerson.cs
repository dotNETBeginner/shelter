using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1__лаба_7_
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }

        void Display();
    }
}
