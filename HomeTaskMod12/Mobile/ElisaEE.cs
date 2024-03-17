using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    internal class ElisaEE : ForeignNetworks
    {
        private double callsCost = 0;
        private double smsCost = 0.1;
        private double internetCost = 15.00;
        public override void ShowServices()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Teid tervitab mobiilsideoperaator");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($" {Name}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($". Täname teid meie teenuste kasutamise eest.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Kättesaadavad teenused: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Kõned kõikidesse võrkudesse - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{callsCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"eur.");
            Console.Write($"                  SMS - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{smsCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"eur.");
            Console.Write($"                  Piiramatu internet - ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{internetCost} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"eur.");
            Thread.Sleep(1000);
            Console.Write("Signaalitugevus - ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Suurepärane");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
