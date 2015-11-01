using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_I
{
    [Serializable]  
    class gameSave
    {
        public playerClass player { get; set; }
        public board gameBoard { get; set; }
        public gameSave(playerClass p, board b)
        {
            player = p;
            gameBoard = b;
        }
    }

}
