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
    }
}