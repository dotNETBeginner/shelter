using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces.IEFServices
{
    public interface IEFUserBoughtService
    {
        Task AddUserBought(UserBought userBought);

        Task UpdateUserBought(UserBought userBought);

        Task DeleteUserBought(UserBought userBought);

        Task<UserBought> GetUserBoughtById(int Id);

        Task<IEnumerable<UserBought>> GetAllUserBoughts();
    }
}
