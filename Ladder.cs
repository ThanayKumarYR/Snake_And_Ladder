using System;
namespace Snake_And_Ladder
{
    class Ladder
    {
        private static readonly int[,] LADDER = new int[8, 2] { { 1, 38 }, { 4, 14 }, { 8, 20 }, { 21, 42 }, { 28, 76 }, { 50, 67 }, { 71, 92 }, { 80, 99 } };
        public static void potentailOfClimbing(Players player)
        { 
            for (int i = 0; i < 8; i++)
            {
                if (LADDER[i, 0] == player.getCurrentPlace())
                {
                    player.setCurrentPlace(LADDER[i, 1]);
                }
            }
        }
    }
}
