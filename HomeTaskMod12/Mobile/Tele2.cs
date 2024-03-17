using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    internal class Tele2 : ForeignNetworks
    {
        private double callsCost = 0;
        private double smsCost = 0.7;
        private double internetCost = 150.00;
        public override void ShowServices()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Du välkomnas av mobiloperatören");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($" {Name}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($". Tack för att du använder våra tjänster.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Tillgängliga tjänster: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Samtal till alla nätverk - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{callsCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"sek.");
            Console.Write($"                  SMS - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{smsCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"sek.");
            Console.Write($"                  Obegränsat Internet - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{internetCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"sek.");
            Thread.Sleep(1000);
            Console.Write("Signalstyrka - ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Utmärkt");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
