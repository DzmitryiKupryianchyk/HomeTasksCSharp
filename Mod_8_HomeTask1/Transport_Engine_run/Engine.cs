using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Engine_run
{
     class Engine
    {
        public void RunEngine() 
        {
            Console.WriteLine("Врум врум!");
            Thread.Sleep(1000);
            Console.WriteLine("Двигатель заведен.");
        }
    }
}
