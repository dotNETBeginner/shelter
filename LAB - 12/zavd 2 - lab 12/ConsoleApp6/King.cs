using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public delegate void RoyalHandler(object sender, RoyalEventArgs args);

    class King : Handled
    {

        public string Name { get; set; }

        public King(string name)
        {
            someHandler = new Handler();
            RoyalEvent += someHandler.RoyalHandler;

            Name = name;
        }

        public override string ToString()
        { return $"{Name}"; }


    }
}
