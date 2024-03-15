using System;

namespace Snake_And_Ladder
{
    class Program

    {
        static void Main()
        {
            bool playing = true;
            try 
            {
                Console.WriteLine("\t\t\t\t\t\tWelcome to Snake and Ladder Game !\n");

                Console.Write("Enter the number of players = ");

                int numOfPlayers = int.Parse(Console.ReadLine());

                if (2 > numOfPlayers ||  numOfPlayers > 10) 
                {
                    Console.WriteLine("\nThe number of players must be between 2 to 10!\n\n"); 
                    return;
                }


                Console.WriteLine($"\t\t\t\t\t\tCreating {numOfPlayers} players for the game !\n");


                Players[] players = new Players[numOfPlayers];

                for (int i = 0; i < numOfPlayers; i++)
                {
                    Console.Write($"Enter the name of the player = ");
                    string name = Console.ReadLine();
                    players[i] = new Players(i, name);

                    Console.WriteLine("\n*********************************************************");
                    players[i].status();
                    Console.WriteLine("*********************************************************\n");
                }
                Console.WriteLine("\n Lets start the game !\n");

                while (playing == true)
                {
                    Console.WriteLine("\nTime to roll the dices\n");
                    Console.Write("Press 'y':continue and 'n':quit = ");
                    char choice = char.Parse(Console.ReadLine());
                    if (choice == 'N' || choice == 'n')
                    {
                        playing = false;
                    }
                    int winnerID = Dice.rollDice(players);

                    if (winnerID == 200)
                        continue;
                    else 
                    {
                        Console.WriteLine($"\n\n\t\t\t.........Congratulations ! Player named {players[winnerID].getName()} has won the game........\n\n"); 
                        return;
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine();
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine();
                //Console.WriteLine(ex.ToString());
            }
            finally
            { 
                Console.WriteLine("Thanks for playing the snake and ladder game !");
            }
        }
    }
}
