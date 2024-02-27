using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Engine_run
{
    abstract class Transport
    {
        public Engine engine;
        public Transport(Engine engine) 
        { 
            this.engine = engine;
        }
        public abstract void Move();
    }
}
