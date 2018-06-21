using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human:Players
    {



        public Human()
        {
            humanPlayer1 = ("Player One");
            humanPlayer2 = ("Player Two");
        }


        public override void ChoosePlayer()
        {
            base.ChoosePlayer();

            Console.WriteLine("What is player two's name?");
            Console.ReadLine();


        }



    }
}
