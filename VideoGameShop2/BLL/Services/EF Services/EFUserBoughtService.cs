using BLL.Interfaces.IEFServices;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.EF_Services
{
    public class EFUserBoughtService : IEFUserBoughtService
    {
        IEFUnitOfWork _efUnitOfWork;

        public EFUserBoughtService(IEFUnitOfWork efunitOfWork)
        { _efUnitOfWork = efunitOfWork; }

        public async Task<IEnumerable<UserBought>> GetAllUserBoughts()
        { return await _efUnitOfWork.EFUserBoughtRepository.GetAll(); }

        public async Task<UserBought> GetUserBoughtById(int Id)
        { return await _efUnitOfWork.EFUserBoughtRepository.Get(Id); }

        public async Task AddUserBought(UserBought userBought)
        { await _efUnitOfWork.EFUserBoughtRepository.Add(userBought); }

        public async Task DeleteUserBought(UserBought userBought)
        { await _efUnitOfWork.EFUserBoughtRepository.Delete(userBought); }

        public async Task UpdateUserBought(UserBought userBought)
        { await _efUnitOfWork.EFUserBoughtRepository.Update(userBought); }
    }
}