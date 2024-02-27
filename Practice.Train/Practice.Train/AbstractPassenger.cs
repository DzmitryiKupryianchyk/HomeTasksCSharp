using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Train
{
    internal abstract class AbstractPassenger
    {
        public string name;
        public string lastName;
        public bool hasTicket;
        public AbstractPassenger(string name, string lastName, bool hasTicket)
        {
            this.name = name;
            this.lastName = lastName;
            this.hasTicket = hasTicket;
        }
    }
}
