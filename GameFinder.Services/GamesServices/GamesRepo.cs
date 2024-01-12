using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Data;
using GameFinder.Models.Models;

namespace GameFinder.Services.GamesServices
{
    public class GamesRepo : IGamesRepo
    {
        private readonly AppDbContext _context;

        public GamesRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<GetGames> GetGameByNameAsync(string name)
        {
            var game = await _context.Games.FindAsync(name);
            if (game != null)
            {
                GetGames result = new()
                {

                };
                return result;
            }
            else return null;
        }
    }
}