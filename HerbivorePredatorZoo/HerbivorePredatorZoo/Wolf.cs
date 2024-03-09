using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Wolf : Predator
    {
        public override void Live()
        {
            Console.Write(nameof(Wolf));
            Hunt();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{nameof(Wolf)} Поймал зайца.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(nameof(Wolf));
            Relax();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
