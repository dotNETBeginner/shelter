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
    public class EFDeveloperRepository : GenericRepository<Developer, int>, IEFDeveloperRepository
    {
        private readonly MyDbContext _dbcontext;

        public EFDeveloperRepository(MyDbContext dbcontext)
            :base(dbcontext)
        {}

        public async Task<IEnumerable<Developer>> GetAllDevelopers()
        {
            return await _dbcontext.Set<Developer>().ToListAsync();
        }

        public async Task<Developer> GetDeveloperById(int Id)
        {
            return await _dbcontext.Set<Developer>().FindAsync(Id);
        }

        public async Task AddDeveloper(Developer developer)
        {
            await _dbcontext.AddAsync(developer);
        }

        public async Task DeleteDeveloper(Developer developer)
        {
            _dbcontext.Entry(developer).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }

        public async Task UpdateDeveloper(Developer developer)
        {
            _dbcontext.Entry(developer).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }
    }
}
