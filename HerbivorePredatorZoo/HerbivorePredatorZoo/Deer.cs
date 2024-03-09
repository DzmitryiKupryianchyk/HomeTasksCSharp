using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Deer : HerbivoreAnimal
    {
        public override void Live()
        {
            Console.Write(nameof(Deer));
            EatGreenery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{nameof(Deer)} Пощипал травку.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(nameof(Deer));
            Relax();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
