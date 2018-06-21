using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Players
    {
        public string humanPlayer1;
        public string computerAi;
        public string humanPlayer2;
        public string playerGesture;
        public string GesturesName;
        

        public Players()
        {
            
        
        }


        public virtual void ChoosePlayer()
        {

        }

        public virtual void ChooseGesture()
        {

        }

        public static void Main()
        {
            List<Players> gesture = new List<Players>();
            gesture.Add(new Players() { GesturesName = "rock" });
            gesture.Add(new Players() { GesturesName = "paper" });
            gesture.Add(new Players() { GesturesName = "scissors" });
            gesture.Add(new Players() { GesturesName = "lizard" });
            gesture.Add(new Players() { GesturesName = "spock" });

       }



    }
}