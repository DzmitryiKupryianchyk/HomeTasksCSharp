using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Train
{
    internal abstract class AbstractCarriage
    {
        public int seats;
        public AbstractCarriage() 
        {
        }
        public abstract void AddPassenger(Passenger passenger);
        public abstract void RemovePassenger();
        public abstract void GetListOfPassengers();
        public abstract int GetCapacityOfCarriage();
        public abstract void AreAllPassengersAllowed(int ind, out bool readyToRun);
    }
}
