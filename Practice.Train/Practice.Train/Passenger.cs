using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Train
{
    internal class Passenger : AbstractPassenger
    {
        public Passenger(string name, string lastName, bool hasTicket) : base(name, lastName, hasTicket)
        {

        }

    }
}
