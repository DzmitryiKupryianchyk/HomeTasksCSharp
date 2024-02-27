using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Engine_run
{
    internal class Car : Transport
    {
        public Car(Engine engine) : base(engine) 
        { 
        }
        public override void Move()
        {
            engine.RunEngine();
            Thread.Sleep(500);
            Console.Beep();
            Thread.Sleep(500);
            Console.WriteLine("Машина поехала.");
            Console.WriteLine();
        }
    }
}
