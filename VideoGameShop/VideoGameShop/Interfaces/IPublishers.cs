using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameShop.Interfaces
{
    public interface IPublishers
    {
        int AddPublisher(Publishers publisher);

        IEnumerable<Publishers> GetAllPublishers();

        Publishers GetPublisherById(int Id_Publisher);

        int UpdatePublishers(Publishers publisher);

        int DeletePublishers(int Id_Publisher);
    }
}
