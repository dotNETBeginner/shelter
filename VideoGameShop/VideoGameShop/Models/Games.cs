using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameShop
{
    public class Games
    {
        public int Id_Game { get; set; }

        public string Name { get; set; }

        public int Id_Dev { get; set; }

        public double Cost { get; set; }

        public int Id_Genre { get; set; }
    }
}
