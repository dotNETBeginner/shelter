using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL.Interfaces.IEFServices
{
    public interface IEFUserService
    {
        Task AddUser(UserDTO user);

        Task UpdateUser(UserDTO user);

        Task DeleteUser(int Id);

        Task<UserDTO> GetUserById(int Id);

        Task<IEnumerable<UserDTO>> GetAllUsers();
    }
}