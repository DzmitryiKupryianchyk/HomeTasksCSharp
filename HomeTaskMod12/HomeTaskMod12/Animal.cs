using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod12
{
    abstract class Animal
    {
        protected string name;
        protected int numOfLegs;

        public void SetName(string name) 
        {
            this.name = name;
        }
        public string GetName() 
        { 
            return name; 
        }
        public void SetNumOfLegs(int numOfLegs) 
        { 
            this.numOfLegs = numOfLegs;
        }
        public int GetNumOfLegs() 
        {
            return numOfLegs;
        }
        public abstract void DisplayAnimal();
        public abstract void Rest();
    }
}
