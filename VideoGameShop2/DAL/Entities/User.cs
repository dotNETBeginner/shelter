using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces.EntityInterfaces;
using Microsoft.AspNetCore.Identity;

namespace DAL.Entities
{
    public class User : IdentityUser,IEntity<int>
    {
        public int Id { get; set; }
        public double Money { get; set; }
    }
}
