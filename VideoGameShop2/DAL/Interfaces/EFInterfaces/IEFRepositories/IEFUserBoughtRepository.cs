using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFUserBoughtRepository : IGenericRepository<UserBought,int>
    {
        Task<IEnumerable<UserBought>> GetAllUserBoughts();

        Task<UserBought> GetUserBoughtById(int Id);

        Task AddUserBought(UserBought userBought);

        Task DeleteUserBought(int Id);

        Task UpdateUserBought(UserBought userBought);
    }
}
