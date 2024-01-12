using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.Models;
using GameFinder.Services.GamesServices;
using Microsoft.AspNetCore.Mvc;

namespace AgileConsoleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly IGamesRepo _gamesRepo;
        public GamesController(IGamesRepo gamesRepo)
        {
            _gamesRepo = gamesRepo;
        }
        [HttpGet]
        public async Task<IGamesRepo> GetGamesById([FromRoute] int gameId)
        {
            gameDetail? details = await _gamesRepo.GetNoteByIdAsync(gameId);


            return details is not null
                ? Ok(details)
                : NotFound();
        }
        [HttpGet]
        [ProducesResponseType(typeof(IGamesRepo<GetGames>), 200)]
        public async Task<IGamesRepo> GetAllGames()
        {
            var games = await _gamesRepo.GetAllGamesAsync();
            return Ok(games);
        }
    }
}