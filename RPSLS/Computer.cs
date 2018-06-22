using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer:Players
    {
        


        public Computer(string computerAi)
        {
            this.computerAi = computerAi;
        }




        public override void ChooseGesture()
        {
            base.ChooseGesture();

        }
    }
}
