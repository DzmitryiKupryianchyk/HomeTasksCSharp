using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Train
{
    internal abstract class AbstractTrain
    {
        public List<Carriage> carriages;
        
        public AbstractTrain(List<Carriage> carriages) 
        {
        }
        public abstract void AddCarriage(Carriage carriage);
        public abstract void RemoveCarriage();
        public abstract void GetNumOfCarriages();
        public abstract void GetCapacityOfTrain();
        public abstract bool IsAllowedToMove(ref List<bool> allowanceFromEachCarriege);
        public abstract void Move(out bool succeeded);
    }
}
