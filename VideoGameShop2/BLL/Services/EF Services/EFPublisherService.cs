using BLL.Interfaces.IEFServices;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.EF_Services
{
    public class EFPublisherService : IEFPublisherService
    {
        IEFUnitOfWork _efUnitOfWork;

        public EFPublisherService(IEFUnitOfWork efunitOfWork)
        { _efUnitOfWork = efunitOfWork; }

        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        { return await _efUnitOfWork.EFPublisherRepository.GetAll(); }

        public async Task<Publisher> GetPublisherById(int Id)
        { return await _efUnitOfWork.EFPublisherRepository.Get(Id); }

        public async Task AddPublisher(Publisher publisher)
        { await _efUnitOfWork.EFPublisherRepository.Add(publisher); }

        public async Task DeletePublisher(Publisher publisher)
        { await _efUnitOfWork.EFPublisherRepository.Delete(publisher); }

        public async Task UpdatePublisher(Publisher publisher)
        { await _efUnitOfWork.EFPublisherRepository.Update(publisher); }
    }
}
