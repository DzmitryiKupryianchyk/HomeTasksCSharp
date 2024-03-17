using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    internal class LocalNetworks : MobileNetwork
    {
        public override void ShowServices()
        {
            throw new NotImplementedException();
        }
        
        public void SwitchRoam()
        {
            Roaming();
        }
    }
}
