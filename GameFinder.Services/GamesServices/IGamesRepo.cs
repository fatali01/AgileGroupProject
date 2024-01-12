using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Models.Models;

namespace GameFinder.Services.GamesServices
{
    public interface IGamesRepo
    {
        Task<GetGames> GetGameByNameAsync(string name);
    }
}