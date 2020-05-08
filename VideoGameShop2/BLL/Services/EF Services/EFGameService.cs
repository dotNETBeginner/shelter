using BLL.DTO;
using BLL.Interfaces.IEFServices;
using DAL.Entities;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL.Services.EF_Services
{
    public class EFGameService : IEFGameService
    {
        IEFUnitOfWork _efUnitOfWork;
        private readonly IMapper _mapper;

        public EFGameService(IEFUnitOfWork efunitOfWork, IMapper mapper)
        {
            _efUnitOfWork = efunitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GameDTO>> GetAllGames()
        {
            var x = await _efUnitOfWork.EFGameRepository.GetAll();
            List<GameDTO> res = new List<GameDTO>();
            foreach (var i in x)
                res.Add(_mapper.Map<Game, GameDTO>(i));

            return res;
        }

        public async Task<GameDTO> GetGameById(int Id)
        {
            var x = await _efUnitOfWork.EFGameRepository.Get(Id);
            GameDTO res = _mapper.Map<Game, GameDTO>(x);

            return res;
        }

        public async Task AddGame(GameDTO game)
        {
            var x = _mapper.Map<GameDTO, Game>(game);
            await _efUnitOfWork.EFGameRepository.Add(x);
        }

        public async Task DeleteGame(int Id)
        { await _efUnitOfWork.EFGameRepository.Delete(Id); }

        public async Task UpdateGame(GameDTO game)
        {
            var x = _mapper.Map<GameDTO, Game>(game);
            await _efUnitOfWork.EFGameRepository.Update(x);
        }

        public async Task<GameDTO> GetGameByName(string name)
        {
            var x = await _efUnitOfWork.EFGameRepository.GetGameByName(name);
            GameDTO res = _mapper.Map<Game, GameDTO>(x);

            return res;
        }

        public async Task<GameDTO> GetCheapestGame()
        {
            var x = await _efUnitOfWork.EFGameRepository.GetCheapestGame();
            GameDTO res = _mapper.Map<Game, GameDTO>(x);

            return res;
        }
    }
}