using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces.EntityInterfaces;

namespace DAL.Entities
{
    public class User : IEntity<int>
    {
        public int Id { get; set; }
        public double Money { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
    }
}
