using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder
{
    class Players
    {
        private string name;
        private int id;
        private int currentPlace;
        public Players(int userid, string userName)
        {
            id = userid;
            name = userName;
            currentPlace = 0;
        }

        public int getId() { return id; }
        public int getCurrentPlace() { return currentPlace;}
        public string getName() { return name; }

        public void  setCurrentPlace(int place)
        { currentPlace = place; }

        public void status()
        { 
            int playerId = getId();
            string  playerName = getName();
            int playerPlace = getCurrentPlace();
            Console.WriteLine($"Player Id = {playerId}, Player Name = {playerName}, Current Place = {playerPlace}");
        }

        public void printPlace()
        {
            Console.Write($"\t{name} @ {currentPlace}");
        }
    }
}
