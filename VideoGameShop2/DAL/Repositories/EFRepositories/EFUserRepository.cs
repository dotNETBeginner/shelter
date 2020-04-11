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
    public class EFUserRepository : GenericRepository<User, int>, IEFUserRepository
    {
        private readonly MyDbContext _dbcontext;

        public EFUserRepository(MyDbContext dbcontext)
            : base(dbcontext)
        { }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _dbcontext.Set<User>().ToListAsync();
        }

        public async Task<User> GetUserById(int Id)
        {
            return await _dbcontext.Set<User>().FindAsync(Id);
        }

        public async Task AddUser(User user)
        {
            await _dbcontext.AddAsync(user);
        }

        public async Task DeleteUser(User user)
        {
            _dbcontext.Entry(user).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }

        public async Task UpdateUser(User user)
        {
            _dbcontext.Entry(user).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }
    }
}