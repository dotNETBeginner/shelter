using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces.IEFServices;
using DAL.DbContexts;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VideoGameShop2.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {
        IEFGameService _efGameService;

        public GameController(IEFGameService efGameService)
        { _efGameService = efGameService; }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try { return Ok(await _efGameService.GetAllGames()); }
            catch { return StatusCode(404); }
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> Get(int Id)
        {
            try { return Ok(await _efGameService.GetGameById(Id)); }
            catch { return StatusCode(404); }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                await _efGameService.DeleteGame(Id);
                return StatusCode(204);
            }
            catch
            { return StatusCode(404); }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] GameDTO val)
        {
            try
            {
                await _efGameService.UpdateGame(val);
                return StatusCode(204);
            }
            catch
            { return StatusCode(404); }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GameDTO val)
        {
            try
            {
                await _efGameService.AddGame(val);
                return StatusCode(201);
            }
            catch
            { return StatusCode(404); }
        }

        [HttpGet("name/{name}")]
        public async Task<IActionResult> Get(string name)
        {
            try { return Ok(await _efGameService.GetGameByName(name)); }
            catch { return StatusCode(404); }
        }

        [HttpGet("cheap")]
        public async Task<IActionResult> GetCheapest()
        {
            try { return Ok(await _efGameService.GetCheapestGame());}
            catch { return StatusCode(404); }
        }
    }
}