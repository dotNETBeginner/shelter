using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFPublisherRepository : IGenericRepository<Publisher,int>
    {
        Task<IEnumerable<Publisher>> GetAllPublishers();

        Task<Publisher> GetPublisherById(int Id);

        Task AddPublisher(Publisher publisher);

        Task DeletePublisher(Publisher publisher);

        Task UpdatePublisher(Publisher publisher);
    }
}
