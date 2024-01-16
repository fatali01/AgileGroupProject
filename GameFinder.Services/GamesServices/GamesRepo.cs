using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Data;
using GameFinder.Models.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace GameFinder.Services.GamesServices;

public class GamesRepo : IGamesRepo
{

    private readonly AppDbContext _context;
    public GamesRepo(AppDbContext context)
    {
        _context = context;
    }

    public Task<bool> AddGameToDbAsync(GameModel model)
    {
        if(model != null)
        {
            System.Console.WriteLine("This game is already in the system!");
        }
        else
        {
            
        }
        return ;
    }

    public async Task<GameModel?> GetGameModelByName(string GameName)
    {
        var gameEntity = await _context.Games.FindAsync(GameName);
        if(gameEntity is null)
        return null;

        GameModel gameDetails = new()
        {
            GameName = gameEntity.GameName,
            GameConsole = gameEntity.GameConsole,
            Genre = gameEntity.Genre,
            DateReleased = gameEntity.DateReleased,
        };
        return gameDetails;
    }
}