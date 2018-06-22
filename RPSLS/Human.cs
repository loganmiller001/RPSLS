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
            Human humanPlayer1 = new Human();
            Human humanPlayer2 = new Human();
        }


        public override void ChoosePlayer()
        {
            base.ChoosePlayer();

            Players player1 = new Human();
            Players player2 = new Human();
            Console.WriteLine("What is Player one's name?" + player1);
            Console.WriteLine("What is player two's name?" + player2);
            Console.ReadLine();
            

        }

        public override void ChooseGesture()
        {
            base.ChooseGesture();  

        }

    }
}
