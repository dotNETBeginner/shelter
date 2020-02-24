using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameShop.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoGameShop.Controllers
{
    public class GameController : Controller
    {
        private readonly IGames gameobj;

        public GameController(IGames _gameobj)
        {
            gameobj = _gameobj;
        }

        [HttpPost]
        [Route("Create")]
        public int Create([FromBody] Games game)
        { return gameobj.AddGame(game); }

        [HttpGet]
        public IEnumerable<Games> Get()
        { return gameobj.GetAllGames(); }

        [HttpGet("{Id_Game}")]
        public Games Details(int Id_Game)
        { return gameobj.GetGameById(Id_Game); }

        [HttpPut]
        [Route("Edit")]
        public int Edit([FromBody]Games game)
        { return gameobj.UpdateGame(game); }

        [HttpDelete]
        [Route("Delete/{Id_Game}")]
        public int Delete(int Id_Game)
        { return gameobj.DeleteGame(Id_Game); }

    }
}
