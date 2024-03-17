using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    abstract class MobileNetwork
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public abstract void ShowServices();
    }
  
}
