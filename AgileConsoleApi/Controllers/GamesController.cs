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
        private readonly IGamesRepo _gamesRepo;
        public GamesController(IGamesRepo gamesRepo)
        {
            _gamesRepo = gamesRepo;
        }
    }
}