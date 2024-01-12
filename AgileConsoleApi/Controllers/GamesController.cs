using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Services.GamesServices;
using Microsoft.AspNetCore.Mvc;

namespace AgileConsoleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly IGamesRepo _games;
        [HttpGet]
        public async Task<IActionResult> GetGameByNameAsync(string name)
        {
            var gameDetails = await _games.GetGameByNameAsync(name);
            if (gameDetails is null)
            {
                return BadRequest();
            }
            return Ok(gameDetails);
        }
    }
}