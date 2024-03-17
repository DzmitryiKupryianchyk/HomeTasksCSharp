using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod12
{
    internal interface Herbivore
    {
        string typeH { get; set; }
        string foodH { get; set; }

        void DisplayEatH();
    }
}
