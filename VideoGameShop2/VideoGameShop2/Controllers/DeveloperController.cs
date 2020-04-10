using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.DbContexts;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoGameShop2.Controllers
{
    [Route("api/[controller]")]
    public class DeveloperController : Controller
    {
        private readonly MyDbContext _dbcontext;
        public DeveloperController(MyDbContext dbContext)
        { _dbcontext = dbContext; }

        [HttpGet]
        public IEnumerable<Developer> Get()
        { return _dbcontext.Set<Developer>().ToList(); }
    }
}