using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1_лаба_12
{
    class Handler
    {
        public Handler() { }

        public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        { Console.WriteLine($"Dispetcher`s name changed to {args.Name}"); }
    }
}
