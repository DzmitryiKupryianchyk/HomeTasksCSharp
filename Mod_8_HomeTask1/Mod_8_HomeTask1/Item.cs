using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_8_HomeTask1
{
    class Item
    {
        private string name = "unknown";

        public void SetName(string name) 
        {
            this.name = name;
        }

        public string GetName () 
        { 
            return name; 
        }
    }
}
