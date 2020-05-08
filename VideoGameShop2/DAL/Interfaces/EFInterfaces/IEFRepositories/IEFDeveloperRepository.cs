using DAL.Entities;
using System.Threading.Tasks;

namespace DAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFDeveloperRepository : IGenericRepository<Developer, int>
    {
        Task<Developer> GetDeveloperByName(string name);
    }
}
