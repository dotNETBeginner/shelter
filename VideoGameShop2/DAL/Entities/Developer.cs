using DAL.Entities;
using DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Developer : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Id_Publisher { get; set;}
    }
}
