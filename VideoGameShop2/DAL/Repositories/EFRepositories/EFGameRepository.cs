using DAL.DbContexts;
using DAL.Entities;
using DAL.Interfaces.EFInterfaces.IEFRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.EFRepositories
{
    public class EFGameRepository : GenericRepository<Game, int>, IEFGameRepository
    {
        private readonly MyDbContext _dbcontext;

        public EFGameRepository(MyDbContext dbcontext)
            : base(dbcontext)
        { }

        public async Task<IEnumerable<Game>> GetAllGames()
        {
            return await _dbcontext.Set<Game>().ToListAsync();
        }

        public async Task<Game> GetGameById(int Id)
        {
            return await _dbcontext.Set<Game>().FindAsync(Id);
        }

        public async Task AddGame(Game game)
        {
            await _dbcontext.AddAsync(game);
        }

        public async Task DeleteGame(int Id)
        {
            _dbcontext.Entry(Id).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }

        public async Task UpdateGame(Game game)
        {
            _dbcontext.Entry(game).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }
    }
}
