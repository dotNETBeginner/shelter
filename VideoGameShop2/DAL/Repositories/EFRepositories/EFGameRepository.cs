using DAL.DbContexts;
using DAL.Entities;
using DAL.Interfaces.EFInterfaces.IEFRepositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;

namespace DAL.Repositories.EFRepositories
{
    public class EFGameRepository : GenericRepository<Game, int>, IEFGameRepository
    {
        private readonly IMapper _mapper;

        public EFGameRepository(MyDbContext dbcontext)
            : base(dbcontext)
        { }

        public async Task<Game> GetGameByName(string name)
        {
            var x = await _dbcontext.Set<Game>().ToListAsync();

            return x.Where(x => x.Name == name).FirstOrDefault();
        }

        public async Task<Game>  GetCheapestGame()
        {
            var x = await _dbcontext.Set<Game>().ToListAsync();

            double min = x.Min(a => a.Cost);

            return x.Where(x => x.Cost == min).FirstOrDefault();
        }

    }
}
