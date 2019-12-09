using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class RoyalEventArgs : EventArgs //Класс для аргументов события
    {
        public string Name { get; private set; }

        public RoyalEventArgs(string name)
        { Name = name; }
    }
}
