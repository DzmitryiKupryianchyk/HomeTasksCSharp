using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Bear : Predator
    {
        public override void Live()
        {
            Console.Write(nameof(Bear));
            Hunt();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{nameof(Bear)} Поймал лося.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(nameof(Bear));
            Relax();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
