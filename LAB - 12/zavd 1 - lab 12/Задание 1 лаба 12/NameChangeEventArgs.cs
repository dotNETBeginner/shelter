using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1_лаба_12
{
    public class NameChangeEventArgs : EventArgs
    {
        public string Name { get; private set; }

        public NameChangeEventArgs(string name)
        { Name = name; }
    }
}
