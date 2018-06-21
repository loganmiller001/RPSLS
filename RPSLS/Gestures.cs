using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gestures
    {
      public static void Main()
        {
            List<Gestures> gesture = new List<Gestures>();
            gesture.Add(new Gestures() { GesturesName = "rock" });
            gesture.Add(new Gestures() { GesturesName = "paper" });
            gesture.Add(new Gestures() { GesturesName = "scissors" });
            gesture.Add(new Gestures() { GesturesName = "lizard" });
            gesture.Add(new Gestures() { GesturesName = "spock" });

        }

        //member variables
        public string chooseGesture;
        public string gestureBeats;
        public string gestureType;
        public string GesturesName;


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
