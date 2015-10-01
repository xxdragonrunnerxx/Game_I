using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_I
{
    class tile
    {
        public string symbol { get; set; }
        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
        public bool playerHere { get; set; }
        public bool stairsHere { get; set; }
        public bool wall { get; set; }
        public tile(string s, ConsoleColor f, ConsoleColor b, bool w)
        {
            symbol = s;
            ForegroundColor = f;
            BackgroundColor = b;
            playerHere = false;
            stairsHere = false;
            wall = w;
        }
        
    }
}
