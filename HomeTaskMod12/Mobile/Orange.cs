using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    internal class Orange : ForeignNetworks
    {
        private double callsCost = 0;
        private double smsCost = 0.6;
        private double internetCost = 60.00;
        public override void ShowServices()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Wita Cię operator komórkowy");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($" {Name}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($". Dziękujemy za korzystanie z naszych usług.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Dostępne usługi: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Połączenia do wszystkich sieci - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{callsCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"zl.");
            Console.Write($"                  SMS - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{smsCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"zl.");
            Console.Write($"                  Nieograniczony Internet - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{internetCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"zl.");
            Thread.Sleep(1000);
            Console.Write("Siła sygnału - ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Doskonały");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
