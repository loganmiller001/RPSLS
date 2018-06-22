using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human:Players
    {



        public Human(string humanPlayerName)
        {
            this.humanPlayerName = humanPlayerName;
        }




        public override void ChooseGesture()
        {
            base.ChooseGesture();  

        }

    }
}
