using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    class Board
    {
        public static int Rules(Players players, int diceNumber)
        { 
            if ((players.getCurrentPlace()+diceNumber)<100)
                return 200;
            else if ((players.getCurrentPlace() + diceNumber) == 100)
                return players.getId();
            else return 404;
        }

    }
}
