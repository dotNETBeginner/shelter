using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces.IEFServices
{
    public interface IEFDeveloperService
    {
        Task AddDeveloper(Developer developer);

        Task UpdateDeveloper(Developer developer);

        Task DeleteDeveloper(Developer developer);

        Task<Developer> GetDeveloperById(int Id);

        Task<IEnumerable<Developer>> GetAllDevelopers();
    }
}
