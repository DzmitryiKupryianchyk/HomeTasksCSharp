using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    internal class Velcom : MobileNetwork
    {
        private double callsCost = 0;
        private double smsCost = 0.3;
        private double internetCost = 30.00;

        public override void ShowServices()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Доступные услуги: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Звонки во все сети - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{callsCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"руб.");
            Console.Write($"                  СМС - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{smsCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"руб.");
            Console.Write($"                  Безлимитный интернет - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{internetCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"руб.");
            Thread.Sleep(1000);
            Console.Write("Уровень сигнала - ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Отличный");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    
}
