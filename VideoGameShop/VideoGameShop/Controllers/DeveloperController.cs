using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameShop.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoGameShop.Controllers
{
    public class DeveloperController : Controller
    {
        private readonly IDevelopers developerobj;

        public DeveloperController(IDevelopers _developerobj)
        { developerobj = _developerobj; }

        [HttpPost]
        [Route("Create")]
        public int Create([FromBody] Developers developer)
        { return developerobj.AddDeveloper(developer); }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<Developers> Index()
        { return developerobj.GetAllDevelopers(); }

        [HttpGet]
        [Route("Details/{Id_Developer}")]
        public Developers Details(int Id_Developer)
        { return developerobj.GetDeveloperById(Id_Developer); }

        [HttpPut]
        public int Edit([FromBody]Developers developer)
        { return developerobj.UpdateDeveloper(developer); }

        [HttpDelete("{Id_Developer}")]
        public int Delete(int Id_Developer)
        { return developerobj.DeleteDeveloper(Id_Developer); }
    }
}
