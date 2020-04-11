using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces.IEFServices
{
    public interface IEFUserService
    {
        Task AddUser(User user);

        Task UpdateUser(User user);

        Task DeleteUser(User user);

        Task<User> GetUserById(int Id);

        Task<IEnumerable<User>> GetAllUsers();
    }
}