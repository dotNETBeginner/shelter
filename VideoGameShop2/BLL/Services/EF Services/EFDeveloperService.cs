using BLL.Interfaces.IEFServices;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.EF_Services
{
    public class EFDeveloperService : IEFDeveloperService
    {
        IEFUnitOfWork _efUnitOfWork;

        public EFDeveloperService(IEFUnitOfWork efunitOfWork)
        { _efUnitOfWork = efunitOfWork; }

        public async Task<IEnumerable<Developer>> GetAllDevelopers()
        { return await _efUnitOfWork.EFDeveloperRepository.GetAll(); }

        public async Task<Developer> GetDeveloperById(int Id)
        { return await _efUnitOfWork.EFDeveloperRepository.Get(Id); }

        public async Task AddDeveloper(Developer developer)
        { await _efUnitOfWork.EFDeveloperRepository.Add(developer); }

        public async Task DeleteDeveloper(Developer developer)
        { await _efUnitOfWork.EFDeveloperRepository.Delete(developer); }

        public async Task UpdateDeveloper(Developer developer)
        { await _efUnitOfWork.EFDeveloperRepository.Update(developer); }
    }
}
