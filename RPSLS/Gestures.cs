using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gestures
    {
        List<string> HandSignals = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };


        //member variables
        public string chooseGesture;
        public string gestureBeats;
        public string gestureType;


        //constructor
        public Gestures()
        {
            
        }
        
        //member methods
        public void DisplayGestureChoices()
        {
            Console.WriteLine("You may choose between: 'Rock', 'Paper', 'Scissors', 'Lizard', and 'Spock'");
            Console.ReadLine();

        }

        public virtual void ShowPickedGesture()
        {
            Console.WriteLine("You have choosen: " + gestureType);
        }

        public virtual void DetermineResult()
        {

        }

       
    }
}
