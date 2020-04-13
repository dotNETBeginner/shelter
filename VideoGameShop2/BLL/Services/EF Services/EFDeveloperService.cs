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
    public class EFDeveloperService : IEFDeveloperService
    {
        IEFUnitOfWork _efUnitOfWork;
        private readonly IMapper _mapper;

        public EFDeveloperService(IEFUnitOfWork efunitOfWork, IMapper mapper)
        { 
            _efUnitOfWork = efunitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DeveloperDTO>> GetAllDevelopers()
        {
            var x = await _efUnitOfWork.EFDeveloperRepository.GetAll();
            List<DeveloperDTO> res = new List<DeveloperDTO>();
            foreach(var i in x)
                res.Add(_mapper.Map<Developer, DeveloperDTO>(i));

                return res;
        }

        public async Task<DeveloperDTO> GetDeveloperById(int Id)
        {
            var x = await _efUnitOfWork.EFDeveloperRepository.Get(Id);
            DeveloperDTO res = _mapper.Map<Developer, DeveloperDTO>(x);

            return res;
        }

        public async Task AddDeveloper(DeveloperDTO developer)
        {
            var x = _mapper.Map<DeveloperDTO,Developer>(developer);
            await _efUnitOfWork.EFDeveloperRepository.Add(x);
        }

        public async Task DeleteDeveloper(int Id)
        { await _efUnitOfWork.EFDeveloperRepository.Delete(Id); }

        public async Task UpdateDeveloper(DeveloperDTO developer)
        {
            var x = _mapper.Map<DeveloperDTO, Developer>(developer);
            await _efUnitOfWork.EFDeveloperRepository.UpdateDeveloper(x);
        }
    }
}
