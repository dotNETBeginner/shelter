using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFPublisherRepository : IGenericRepository<Publisher,int>
    {
        Task<Publisher> GetGenreByName(string name);
    }
}
