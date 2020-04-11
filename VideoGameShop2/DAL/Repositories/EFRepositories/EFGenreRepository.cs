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
    public class EFGenreRepository : GenericRepository<Genre, int>, IEFGenreRepository
    {
        private readonly MyDbContext _dbcontext;

        public EFGenreRepository(MyDbContext dbcontext)
            : base(dbcontext)
        { }

        public async Task<IEnumerable<Genre>> GetAllGenres()
        {
            return await _dbcontext.Set<Genre>().ToListAsync();
        }

        public async Task<Genre> GetGenreById(int Id)
        {
            return await _dbcontext.Set<Genre>().FindAsync(Id);
        }

        public async Task AddGenre(Genre genre)
        {
            await _dbcontext.AddAsync(genre);
        }

        public async Task DeleteGenre(Genre genre)
        {
            _dbcontext.Entry(genre).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }

        public async Task UpdateGenre(Genre genre)
        {
            _dbcontext.Entry(genre).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }
    }
}