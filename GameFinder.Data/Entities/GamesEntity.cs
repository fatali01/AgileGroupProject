using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameFinder.Data.Enums;

namespace GameFinder.Data.Entities
{
    public class GamesEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }=string.Empty;
        public string GameDescription { get; set; }=string.Empty;
        public GameConsole GameConsole { get; set; }
        public Genre Genre { get; set; }
        public Ratings Rating { get; set; }
        public DateTime DateReleased { get; set; }
        
    }
}