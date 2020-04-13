using DAL.DbContexts;
using DAL.Interfaces;
using DAL.Interfaces.EntityInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        private readonly MyDbContext _dbcontext;

        public GenericRepository(MyDbContext dbcontext)
        { _dbcontext = dbcontext; }

        public async Task<IEnumerable<TEntity>> GetAll()
        { return await _dbcontext.Set<TEntity>().ToListAsync(); }

        public async Task<TEntity> Get(TId id)
        { return await _dbcontext.Set<TEntity>().FindAsync(id); }

        public async Task Add(TEntity entity)
        { await _dbcontext.AddAsync(entity); }

        public async Task Update(TEntity entity)
        { 
             _dbcontext.Entry(entity).State = EntityState.Modified;
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Delete(TId Id)
        { 
            _dbcontext.Entry(Id).State = EntityState.Deleted;
            await _dbcontext.SaveChangesAsync();
        }
    }
}
