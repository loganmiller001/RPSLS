using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Players
    {
        public string humanPlayerName;
        public string computerAi;
        public int gesture;
        public int wins;
        public int losses;
        public int choice;

        public Players()
        {
            
        
        }



        public virtual int PlayerGesture()
        {
            int choice = 0;
            Console.WriteLine("Please enter the gesture you wish to use. Your choices are 'rock', 'paper', 'scissors', 'spock', 'lizard'");
            string switchCondition = Console.ReadLine();
            switchCondition.ToLower();

            switch (switchCondition)
            {

                case "rock":
                    choice = 0;
                    break;
                case "paper":
                    choice = 1;
                    break;
                case "scissors":
                    choice = 2;
                    break;
                case "spock":
                    choice = 3;
                    break;
                case "lizard":
                    choice = 4;
                    break;
                default:
                    Console.WriteLine("Incorrect choice! Please pick again using the five choices.");
                    PlayerGesture();
                    break;
                
            }
            return choice;
        }

        public virtual int ComputerGesture()
        {
            Random rnd = new Random();
            int gesture = rnd.Next(0, 4);
            return gesture;
        }


        public string GestureList()
        {
            List<string> GestureList = new List<string>();
            GestureList.Add("rock");
            GestureList.Add("paper");
            GestureList.Add("scissor");
            GestureList.Add("spock");
            GestureList.Add("lizard");

            return GestureList[choice];

       }



    }
}