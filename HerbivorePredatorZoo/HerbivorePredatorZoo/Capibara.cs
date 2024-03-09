using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Capibara : HerbivoreAnimal
    {
        public override void Live()
        {
            Console.Write(nameof(Capibara));
            EatGreenery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{nameof(Capibara)} Пожевал травку.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(nameof(Capibara));
            Relax();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
