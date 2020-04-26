using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFGameRepository : IGenericRepository<Game,int>
    {
        Task<Game> GetGameByName(string name);
        Task<Game> GetCheapestGame();
    }
}
