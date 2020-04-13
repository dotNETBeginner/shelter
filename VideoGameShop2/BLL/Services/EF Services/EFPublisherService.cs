using BLL.DTO;
using BLL.Interfaces.IEFServices;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL.Services.EF_Services
{
    public class EFPublisherService : IEFPublisherService
    {
        IEFUnitOfWork _efUnitOfWork;
        private readonly IMapper _mapper;

        public EFPublisherService(IEFUnitOfWork efunitOfWork, IMapper mapper)
        {
            _efUnitOfWork = efunitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PublisherDTO>> GetAllPublishers()
        {
            var x = await _efUnitOfWork.EFPublisherRepository.GetAll();
            List<PublisherDTO> res = new List<PublisherDTO>();
            foreach (var i in x)
                res.Add(_mapper.Map<Publisher, PublisherDTO>(i));

            return res;
        }

        public async Task<PublisherDTO> GetPublisherById(int Id)
        {
            var x = await _efUnitOfWork.EFPublisherRepository.Get(Id);
            PublisherDTO res = _mapper.Map<Publisher, PublisherDTO>(x);

            return res;
        }

        public async Task AddPublisher(PublisherDTO publisher)
        {
            var x = _mapper.Map<PublisherDTO, Publisher>(publisher);
            await _efUnitOfWork.EFPublisherRepository.Add(x);
        }

        public async Task DeletePublisher(int Id)
        { await _efUnitOfWork.EFPublisherRepository.Delete(Id); }

        public async Task UpdatePublisher(PublisherDTO publisher)
        {
            var x = _mapper.Map<PublisherDTO, Publisher>(publisher);
            await _efUnitOfWork.EFPublisherRepository.Update(x);
        }
    }
}