using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Tiger : Predator
    {
        public override void Live()
        {
            Console.Write(nameof(Tiger));
            Hunt();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{nameof(Tiger)} Поймал оленя.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(nameof(Tiger));
            Relax();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
