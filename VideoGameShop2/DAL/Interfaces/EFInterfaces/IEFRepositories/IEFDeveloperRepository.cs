using DAL.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFDeveloperRepository : IGenericRepository<Developer, int>
    {
        Task<IEnumerable<Developer>> GetAllDevelopers();

        Task<Developer> GetDeveloperById(int Id);

        Task AddDeveloper(Developer developer);

        Task DeleteDeveloper(Developer developer);

        Task UpdateDeveloper(Developer developer);
    }
}
