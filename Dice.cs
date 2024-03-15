using System;
namespace Snake_And_Ladder
{
    class Dice
    {
        public static void rollDice(Players[] obj)
        {
            Random random = new Random();   
            foreach (var item in obj)
            {
                int place = item.getCurrentPlace();
                item.setCurrentPlace(place + random.Next(1,7));
                item.printPlace();
            }
            Console.WriteLine();
        }
    }
}
