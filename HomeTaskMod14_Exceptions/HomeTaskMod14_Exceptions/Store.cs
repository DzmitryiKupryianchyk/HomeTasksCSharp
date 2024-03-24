using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod14_Exceptions
{
    internal class Store<T> where T : Goods 
    {
        public Goods milk = new GroceryGoods() {Name = "молоко", isExpired = false, Price = 2.5 };
        public Goods bread = new GroceryGoods() { Name = "хлеб", isExpired = false, Price = 2.0 };
        public Goods juice = new GroceryGoods() { Name = "сок", isExpired = false, Price = 4.0 };
        public Goods noteBook = new NonGroceryGoods() { Name = "блокнот", Price = 5.75 };
        public Goods tShirt = new NonGroceryGoods() { Name = "футболка",Price = 9.25 };
        public Goods glasses = new NonGroceryGoods() { Name = "очки", Price = 10.15 };
        public Goods headphones = new NonGroceryGoods() { Name = "наушники", Price = 12.5 };
        public Goods beer = new Alcohol() { Name = "пиво", Price = 3.45 };
        public Goods liquor = new Alcohol() { Name = "jagermeister", Price = 15.45 };
      
    }
}
