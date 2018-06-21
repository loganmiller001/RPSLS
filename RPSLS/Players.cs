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

        public Players()
        {

        }


        public virtual void ChoosePlayer()
        {
            Console.WriteLine("What is the player one's name? ");
            Console.ReadLine();
            


        }





    }
}