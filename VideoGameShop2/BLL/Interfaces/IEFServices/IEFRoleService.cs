using BLL.DTO;
using System.Threading.Tasks;

namespace BLL.Interfaces.IEFServices
{
    public interface IEFRoleService
    {
        Task CreateRole(RoleDTO role);
        Task AppointRole(int userId, string role);
    }
}
