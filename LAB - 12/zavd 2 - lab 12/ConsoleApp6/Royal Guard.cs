using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class RoyalGuard : Handled
    {
        public string Name { get; set; }

        public RoyalGuard(string name) 
        {
            someHandler = new Handler();
            RoyalEvent += someHandler.RoyalHandler;

            Name = name; 
        }

        public override string ToString()
        { return $"{Name}"; }
    }
}
