using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    internal class Kievstar : ForeignNetworks
    {
        private double callsCost = 0;
        private double smsCost = 2.5;
        private double internetCost = 250.00;
        public override void ShowServices()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Вас вітає мобільний оператор");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($" {Name}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($". Дякуємо Вам за користування нашими послугами.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Доступні послуги: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Дзвінки в усі мережі - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{callsCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"грн.");
            Console.Write($"                  СМС - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{smsCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"грн.");
            Console.Write($"                  Безлімітний інтернет - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{internetCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"грн.");
            Thread.Sleep(1000);
            Console.Write("Рівень сигналу - ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Відмінний");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
