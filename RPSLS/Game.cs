using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Players player1;
        Players player2;


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
           
        }
	}

    
}
    







