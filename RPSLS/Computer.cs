using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer:Players
    {
        


        Computer()
        {
            computerAi = "Player 2 ";
            
            
        }


        public override void ChoosePlayer()
        {
            base.ChoosePlayer();

            Players player1 = new Human();
            Console.WriteLine("What is your name?" + player1);
            Players player2 = new Computer();
            Console.WriteLine("You are playing a against a machine." + player2);
            Console.ReadLine();
        }

        public override void ChooseGesture()
        {
            base.ChooseGesture();

        }
    }
}
