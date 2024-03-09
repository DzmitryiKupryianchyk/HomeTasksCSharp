using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Lion : Predator
    {
        public override void Live()
        {
            Console.Write(nameof(Lion));
            Hunt();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{nameof(Lion)} Поймал зебру.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(nameof(Lion));
            Relax();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
