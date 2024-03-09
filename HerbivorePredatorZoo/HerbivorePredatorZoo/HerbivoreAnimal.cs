using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class HerbivoreAnimal : Animal
    {
        public HerbivoreAnimal(string name) : base(name)
        {
        }

        protected void EatGreenery() 
        {
            Console.Write(" проголодался, и собирается покушать зелени.  ");
            Thread.Sleep(1000);
        }
        protected void Relax() 
        {
            Console.WriteLine("Плещется в пуду");
        }
    }
}
