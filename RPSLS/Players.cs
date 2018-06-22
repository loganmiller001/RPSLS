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
        public string player1Gesture;
        public string player2Gesture;
        public string GesturesName;
        public string computerGesture;
        

        public Players()
        {
            
        
        }



        public virtual void ChooseGesture()
        {

        }

        public static void List()
        {
            List<Players> gesture = new List<Players>();
            gesture.Add(new Players() { GesturesName = "rock" });
            gesture.Add(new Players() { GesturesName = "paper" });
            gesture.Add(new Players() { GesturesName = "scissors" });
            gesture.Add(new Players() { GesturesName = "lizard" });
            gesture.Add(new Players() { GesturesName = "spock" });

          // return gesture[];

       }



    }
}