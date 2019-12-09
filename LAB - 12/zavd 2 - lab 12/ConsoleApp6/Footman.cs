using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Footman : Handled //Клас шута 
    {
        public string Name { get; set; }

        public Footman(string name) 
        {
            someHandler = new Handler();
            RoyalEvent += someHandler.RoyalHandler;

            Name = name; 
        }

        public override string ToString()
        { return $"{Name}"; }
    }
}
