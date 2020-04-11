using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces.IEFServices
{
    public interface IEFGameService
    {
        Task AddGame(Game game);

        Task UpdateGame(Game game);

        Task DeleteGame(Game game);

        Task<Game> GetGameById(int Id);

        Task<IEnumerable<Game>> GetAllGames();
    }
}
