using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFUserRepository : IGenericRepository<User,int>
    {
        Task<IEnumerable<User>> GetAllUsers();

        Task<User> GetUserById(int Id);

        Task AddUser(User user);

        Task DeleteUser(User user);

        Task UpdateUser(User user);
    }
}
