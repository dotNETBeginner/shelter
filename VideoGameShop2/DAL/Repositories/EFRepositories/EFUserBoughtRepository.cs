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
    }
}