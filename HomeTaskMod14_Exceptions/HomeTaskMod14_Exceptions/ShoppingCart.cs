using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod14_Exceptions
{
    public class ShoppingCart<T> where T : Goods
    {
        public List<T> shopping = new List<T>();
    }
}
