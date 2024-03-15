using System;
namespace Snake_And_Ladder
{
    class Dice
    {
        public static int rollDice(Players[] players)
        {
            Random random = new Random();   
            foreach (var player in players)
            {
                int place = player.getCurrentPlace();
                int diceNumber = random.Next(1, 7);
                int ruleCode = Board.Rules(player,diceNumber);
                if (ruleCode == 200)
                {
                    player.setCurrentPlace(place + diceNumber);
                    Ladder.PotentailOfClimbing(player);
                    Snakes.PotentailOffalling(player);

                }
                else if (ruleCode == player.getId())
                {
                    player.setCurrentPlace(place + diceNumber);
                    Console.WriteLine("\n\n**********************************************************************************************************************************************\n");
                    foreach (var user in players)
                    {
                        user.printPlace();
                    }
                    return player.getId();
                }
                player.printPlace();
            }
            Console.WriteLine();
            return 200;
        }
    }
}
