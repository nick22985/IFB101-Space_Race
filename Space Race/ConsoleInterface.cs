using System;
//DO NOT DELETE the two following using statements *********************************
using Game_Logic_Class;
using Object_Classes;


namespace Space_Race
{
    //sadsdw
    class Console_Class
    {
        /// <summary>
        /// Algorithm below currently plays only one game
        /// 
        /// when have this working correctly, add the abilty for the user to 
        /// play more than 1 game if they choose to do so.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {      
            //awsdwasd
             DisplayIntroductionMessage();
            /*                    
             Set up the board in Board class (Board.SetUpBoard)
             Determine number of players - initally play with 2 for testing purposes 
             Create the required players in Game Logic class
              and initialize players for start of a game             
             loop  until game is finished           
                call PlayGame in Game Logic class to play one round
                Output each player's details at end of round
             end loop
             Determine if anyone has won
             Output each player's details at end of the game
           */
           //dsaffsdsdf
            Board.SetUpBoard();
            Console.WriteLine("\tThis game is for 2 to 6 players.");
            Console.Write("\tHow many players (2-6): ");
            int number = int.Parse(Console.ReadLine()); // add try PASS
            if (number > SpaceRaceGame.MAX_PLAYERS || number < SpaceRaceGame.MIN_PLAYERS)
            {
                while (number > 6 || number < 2)
                {
                    Console.WriteLine("Number of Players is not beetween 2-6");
                    number = int.Parse(Console.ReadLine()); // add tryparse
                    Console.Write("\n\n");
                }
            }

            SpaceRaceGame.NumberOfPlayers = number;
            SpaceRaceGame.SetUpPlayers();
            string roundName = "First";
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("\nPress Enter to play a round ...\n");
                Console.ReadKey();
                for(int j = 0; j < SpaceRaceGame.NumberOfPlayers; i++)
                {
                    if(SpaceRaceGame.Players[j].AtFinish == true)
                    {
                        Console.WriteLine("GAME OVER!");
                        Console.ReadKey();
                    }
                    else
                    {

                    }
                }
                SpaceRaceGame.PlayOneRound();
                Console.WriteLine("\t{0} Round\n", roundName);
                roundName = "Next";
                for(int j = 0; j < number; j++)
                {
                    Console.WriteLine("\t{0} on square {1} with {2} yottawatt of power remaining", SpaceRaceGame.Players[j].Name, SpaceRaceGame.Players[j].Position, SpaceRaceGame.Players[j].RocketFuel);
                }

            }
            PressEnter();
        }//end Main

   //wassd
        /// <summary>
        /// Display a welcome message to the console
        /// Pre:    none.
        /// Post:   A welcome message is displayed to the console.
        /// </summary>
        static void DisplayIntroductionMessage()
        {
            Console.WriteLine("\n\tWelcome to Space Race.\n");
        } //end DisplayIntroductionMessage

        /// <summary>
        /// Displays a prompt and waits for a keypress.
        /// Pre:  none
        /// Post: a key has been pressed.
        /// </summary>
        static void PressEnter()
        {
            Console.Write("\nPress Enter to terminate program ...");
            Console.ReadLine();
        } // end PressAny



    }//end Console class
}
