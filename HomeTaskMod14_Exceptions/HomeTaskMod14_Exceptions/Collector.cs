using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod14_Exceptions
{
    internal class Collector
    {
        private double bag = 0;

        public void CollectMoney(double bag) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Приехал инкассатор.");
            Thread.Sleep(1000);
            this.bag += bag;
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Инкассатор забрал деньги.");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Инкассатор уехал.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1000);
        }
    }
}