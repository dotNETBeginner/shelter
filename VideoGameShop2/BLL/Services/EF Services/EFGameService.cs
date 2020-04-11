using BLL.Interfaces.IEFServices;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.EF_Services
{
    public class EFGameService : IEFGameService
    {
        IEFUnitOfWork _efUnitOfWork;

        public EFGameService(IEFUnitOfWork efunitOfWork)
        { _efUnitOfWork = efunitOfWork; }

        public async Task<IEnumerable<Game>> GetAllGames()
        { return await _efUnitOfWork.EFGameRepository.GetAll(); }

        public async Task<Game> GetGameById(int Id)
        { return await _efUnitOfWork.EFGameRepository.Get(Id); }

        public async Task AddGame(Game game)
        { await _efUnitOfWork.EFGameRepository.Add(game); }

        public async Task DeleteGame(Game game)
        { await _efUnitOfWork.EFGameRepository.Delete(game); }

        public async Task UpdateGame(Game game)
        { await _efUnitOfWork.EFGameRepository.Update(game); }
    }
}
