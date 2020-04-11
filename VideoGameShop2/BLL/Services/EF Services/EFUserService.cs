using BLL.Interfaces.IEFServices;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.EF_Services
{
    public class EFUserService : IEFUserService
    {
        IEFUnitOfWork _efUnitOfWork;

        public EFUserService(IEFUnitOfWork efunitOfWork)
        { _efUnitOfWork = efunitOfWork; }

        public async Task<IEnumerable<User>> GetAllUsers()
        { return await _efUnitOfWork.EFUserRepository.GetAll(); }

        public async Task<User> GetUserById(int Id)
        { return await _efUnitOfWork.EFUserRepository.Get(Id); }

        public async Task AddUser(User user)
        { await _efUnitOfWork.EFUserRepository.Add(user); }

        public async Task DeleteUser(User user)
        { await _efUnitOfWork.EFUserRepository.Delete(user); }

        public async Task UpdateUser(User user)
        { await _efUnitOfWork.EFUserRepository.Update(user); }
    }
}