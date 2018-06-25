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

        public int CalculateResults()
        {
            int numberOfGestures = 5;
            int roundWinner = (numberOfGestures + player1.choice - player2.choice);
            return roundWinner;
        }

        public void TheGame(int roundWinner)
        {
            if (roundWinner == 1 || roundWinner == 3)
            {
                Console.WriteLine(" Wins the round.", player1);
                IncrementScores(player1);
            }
            else if (roundWinner == 2 || roundWinner == 4)
            {
                Console.WriteLine(" Wins the round.", player2);
                IncrementScores(player2);
            }
            else if (roundWinner == 0)
            {
                Console.WriteLine("Tie?!");
            }
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
                AskForAnotherGame();
            }
            else if(player2.wins == 2)
            {
                Console.WriteLine("Player two wins the game.");
                AskForAnotherGame();
            }
        }

        public void AskForAnotherGame()
        {
            Console.WriteLine("Would you like to play another game?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                RunGame();
            }
            else if(answer == "no")
            {
                Console.WriteLine("Hope you enjoyed the game.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wrong selection. Please type in 'yes' or 'no'.");
                AskForAnotherGame();
            }
        }
            
    }
}
    







