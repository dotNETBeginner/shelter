using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFGameRepository : IGenericRepository<Game,int>
    {
        Task<IEnumerable<Game>> GetAllGames();

        Task<Game> GetGameById(int Id);

        Task AddGame(Game game);

        Task DeleteGame(Game game);

        Task UpdateGame(Game game);
    }
}
