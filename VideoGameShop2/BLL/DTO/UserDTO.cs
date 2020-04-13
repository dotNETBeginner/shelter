using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public double Money { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
    }
}
