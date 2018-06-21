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

            Console.WriteLine("You are playing a against a machine.");
            Console.ReadLine();
        }
    }
}
