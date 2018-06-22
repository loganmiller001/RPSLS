using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
     

        public void StartMenu()
        {
            Console.WriteLine("Is there a second player? Typing 'no' will have you play against a computer'.");
            string userInput = Console.ReadLine();
            userInput.ToLower();
            switch (userInput)
            {
                case "yes":
                    Players player1 = new Human(" ");
                    Players player2 = new Human(" ");
                    Console.WriteLine("What is Player one's name?");
                    Console.WriteLine("What is player two's name?");
                    Console.ReadLine();
                    break;
                case "no":
                    Players humanPlayer1 = new Human(" ");
                    Console.WriteLine("What is your name?");
                    Players computerAi = new Computer("Bob");
                    Console.WriteLine("You are playing a against a machine named: " );
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
            
        }
	}

    
}
    







