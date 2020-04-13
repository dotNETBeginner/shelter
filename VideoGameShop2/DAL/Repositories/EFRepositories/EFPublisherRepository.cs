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
    public class EFPublisherRepository : GenericRepository<Publisher, int>, IEFPublisherRepository
    {
        private readonly MyDbContext _dbcontext;

        public EFPublisherRepository(MyDbContext dbcontext)
            : base(dbcontext)
        { }

        public async Task<IEnumerable<Publisher>> GetAllPublishers()
        {
            return await _dbcontext.Set<Publisher>().ToListAsync();
        }

        public async Task<Publisher> GetPublisherById(int Id)
        {
            return await _dbcontext.Set<Publisher>().FindAsync(Id);
        }

        public async Task AddPublisher(Publisher publisher)
        {
            await _dbcontext.AddAsync(publisher);
        }

        public async Task DeletePublisher(int Id)
        {
            _dbcontext.Entry(Id).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }

        public async Task UpdatePublisher(Publisher publisher)
        {
            _dbcontext.Entry(publisher).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }
    }
}