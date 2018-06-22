using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Players player1 = new Human();
        Players player2 = new Human();
        Players humanPlayer1 = new Human();
        Players computerAi = new Computer();

        

        public void StartMenu()
        {
            Console.WriteLine("Is there a second player?");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "yes":
                    Players player1 = new Human();
                    Players player2 = new Human();
                    Console.WriteLine("What is Player one's name?" + player1);
                    Console.WriteLine("What is player two's name?" + player2);
                    Console.ReadLine();

                    break;
                case "no":
                    Players humanPlayer1 = new Human();
                    Console.WriteLine("What is your name?" + humanPlayer1);
                    Players humanPlayer2 = new Computer();
                    Console.WriteLine("You are playing a against a machine." + computerAi);
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
        
	}

    
}
    







