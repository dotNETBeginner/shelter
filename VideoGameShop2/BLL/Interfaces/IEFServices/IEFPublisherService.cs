using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces.IEFServices
{
    public interface IEFPublisherService
    {
        Task AddPublisher(Publisher publisher);

        Task UpdatePublisher(Publisher publisher);

        Task DeletePublisher(Publisher publisher);

        Task<Publisher> GetPublisherById(int Id);

        Task<IEnumerable<Publisher>> GetAllPublishers();
    }
}

