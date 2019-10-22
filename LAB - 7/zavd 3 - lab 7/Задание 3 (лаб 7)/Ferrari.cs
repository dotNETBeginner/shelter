using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3__лаб_7_
{
    class Ferrari : IFerrariProperties
    {
        public string NameOfDriver { get; set; }
        public string CarModel { get { return "488-Spider"; } }

        public Ferrari(string name) => NameOfDriver = name;

        public string Break()
        { return "Brakes!"; }
        public string Gas()
        { return "Zadu6avam sA!"; }
        public void Display()
        { Console.WriteLine($"{CarModel}/{Break()}/{Gas()}/{NameOfDriver}"); }
    }
}
