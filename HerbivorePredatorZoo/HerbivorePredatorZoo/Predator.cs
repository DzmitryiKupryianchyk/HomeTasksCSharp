using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Predator : Animal
    {
        protected void Hunt() 
        {
            Console.Write(" проголодался и собирается на охоту.  ");
            Thread.Sleep(1000);
        }
        protected void Relax()
        {
            Console.WriteLine("Греется на солнышке.");
        }
    }
}
