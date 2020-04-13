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
    public class UserController : Controller
    {
        IEFUserService _efUserService;

        public UserController(IEFUserService efUserService)
        { _efUserService = efUserService; }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try { return Ok(await _efUserService.GetAllUsers()); }
            catch { return StatusCode(404); }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int Id)
        {
            try { return Ok(await _efUserService.GetUserById(Id)); }
            catch { return StatusCode(404); }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                await _efUserService.DeleteUser(Id);
                return StatusCode(204);
            }
            catch
            { return StatusCode(404); }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UserDTO val)
        {
            try
            {
                await _efUserService.UpdateUser(val);
                return StatusCode(204);
            }
            catch
            { return StatusCode(404); }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDTO val)
        {
            try
            {
                await _efUserService.AddUser(val);
                return StatusCode(201);
            }
            catch
            { return StatusCode(404); }
        }
    }
}