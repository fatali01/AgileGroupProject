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
        private readonly IGamesRepo games;
        public async Task<IActionResult> GetGameByNameAsync(string name)
        {
            var result = await games.GetGameByNameAsync(name);
            if (result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}