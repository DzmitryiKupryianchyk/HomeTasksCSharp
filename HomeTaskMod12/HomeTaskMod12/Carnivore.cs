using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod12
{
    internal interface Carnivore
    {
        public string typeC { get; set; }
        public string foodC { get; set; }

        public void DisplayEatC();
    }
}
