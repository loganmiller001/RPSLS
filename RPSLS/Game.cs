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
            Console.WriteLine("Is there a second player?");
            string userInput = Console.ReadLine();
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
                    break;
            }
        }
        
	}

    
}
    







