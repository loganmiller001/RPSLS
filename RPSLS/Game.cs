using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        public Players player1;
        public Players player2;
        


        public void RunGame()
        {
            StartMenu();

            RunRound();

            

        }
        public void StartMenu()
        {
            Console.WriteLine("Is there a second player? Typing 'no' will have you play against a computer'.");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "yes":
                    player1 = new Human(" ");
                    player2 = new Human(" ");
                    Console.ReadLine();
                    break;
                case "no":
                    player1 = new Human(" ");
                    player2 = new Computer(" ");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid respone, please type 'yes', or 'no'.");
                    StartMenu();
                    break;
            }

            RunRound();

        }
        public void RunRound()
        {
            player1.PlayerGesture();
            DisplayResult(player1);
            player2.PlayerGesture();           
            DisplayResult(player2);
            

        }

        public void DisplayResult(Players player)
        {
            switch (player.GestureList())
            {
                case "{0}":
                    Console.WriteLine("Has picked rock.");
                    break;
                case "{1}":
                    Console.WriteLine("Has picked paper.");
                    break;
                case "{2}":
                    Console.WriteLine("Has picked scissors.");
                    break;
                case "{3}":
                    Console.WriteLine("Has picked spock");
                    break;
                case "{4}":
                    Console.WriteLine("Has picked lizard");
                    break;
                
            }
        }



        public void IncrementScores(Players player)
        {
            player.wins++;
        }

        public void CheckWinner()
        {
            if (player1.wins == 2)
            {
                Console.WriteLine("Player one wins the game.");
            }
            else if(player2.wins == 2)
            {
                Console.WriteLine("Player two wins the game.");
            }
        }
            
    }
}
    







