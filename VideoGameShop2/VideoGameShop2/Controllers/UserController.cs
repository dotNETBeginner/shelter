using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.DbContexts;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VideoGameShop2.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly MyDbContext _dbcontext;
        public UserController(MyDbContext dbcontext)
        { _dbcontext = dbcontext; }

        [HttpGet]
        public IEnumerable<User> Get()
        { return _dbcontext.Set<User>().ToList(); }
    }
}