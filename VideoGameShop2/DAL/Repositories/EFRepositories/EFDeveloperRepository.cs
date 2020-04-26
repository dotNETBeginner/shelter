using DAL.DbContexts;
using DAL.Entities;
using DAL.Interfaces.EFInterfaces.IEFRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DAL.Repositories.EFRepositories
{
    public class EFDeveloperRepository : GenericRepository<Developer, int>, IEFDeveloperRepository
    {

        public EFDeveloperRepository(MyDbContext dbcontext)
            :base(dbcontext)
        {
        }

        //Надо оптимизировать
        public async Task <Developer> GetDeveloperByName(string name)
        {
            var x = await _dbcontext.Set<Developer>().ToListAsync();

            return x.Where(x => x.Name == name).FirstOrDefault();
        }
    }
}
