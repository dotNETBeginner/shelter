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

        public async Task<Genre> GetGenreByName(string name)
        { return await _dbcontext.Set<Genre>().FindAsync(name); }
    }
}