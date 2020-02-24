using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameShop.Interfaces
{
    public interface IUsers
    {
        int AddUser(Users user);

        IEnumerable<Users> GetAllUsers();

        Users GetUserById(int Id_User);

        int UpdateUser(Users user);

        int DeleteUser(int Id_User);
    }
}
