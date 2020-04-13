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
    public class EFUserBoughtRepository : GenericRepository<UserBought, int>, IEFUserBoughtRepository
    {
        private readonly MyDbContext _dbcontext;

        public EFUserBoughtRepository(MyDbContext dbcontext)
            : base(dbcontext)
        { }

        public async Task<IEnumerable<UserBought>> GetAllUserBoughts()
        {
            return await _dbcontext.Set<UserBought>().ToListAsync();
        }

        public async Task<UserBought> GetUserBoughtById(int Id)
        {
            return await _dbcontext.Set<UserBought>().FindAsync(Id);
        }

        public async Task AddUserBought(UserBought userBought)
        {
            await _dbcontext.AddAsync(userBought);
        }

        public async Task DeleteUserBought(int Id)
        {
            _dbcontext.Entry(Id).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }

        public async Task UpdateUserBought(UserBought userBought)
        {
            _dbcontext.Entry(userBought).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }
    }
}