using System;

namespace Snake_And_Ladder
{
    class Snakes
    {
        private static readonly int[,] SNAKES = new int[7, 2] { { 32, 10 }, { 36, 6 }, { 48, 26 }, { 62, 18 }, { 88, 24 }, { 95, 56 }, { 97, 78 } };
        public static void PotentailOffalling(Players player)
        {
            for (int i = 0; i < 7; i++)
            {
                if (SNAKES[i, 0] == player.getCurrentPlace())
                {
                    player.setCurrentPlace(SNAKES[i, 1]);
                }
            }
        }
    }
}
