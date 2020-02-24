using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameShop.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoGameShop.Controllers
{
    [Route ("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsers userobj;

        public UsersController(IUsers _userobj)
        {
            userobj = _userobj;
        }

        [HttpPost]
        [Route("Create")]
        public int Create([FromBody] Users user)
        { return userobj.AddUser(user); }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<Users> Index()
        { return userobj.GetAllUsers(); }

        [HttpGet]
        [Route("Details/{Id_User}")]
        public Users Details(int Id_User)
        { return userobj.GetUserById(Id_User); }

        [HttpPut]
        [Route("Edit")]
        public int Edit([FromBody]Users user)
        { return userobj.UpdateUser(user); }

        [HttpDelete]
        [Route("Delete/{Id_User}")]
        public int Delete(int Id_User)
        { return userobj.DeleteUser(Id_User); }
    }
}
