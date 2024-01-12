using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models.Models
{
    public class GameModel
    {
        public string GameName { get; set; }
        public GameConsole GameConsole { get; set; }
        public Genre Genre { get; set; }
        public DateTime DateReleased { get; set; }
    }
}