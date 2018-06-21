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

            Console.WriteLine("What is Player one's name?");
            Console.WriteLine("What is player two's name?");
            Console.ReadLine();


        }



    }
}
