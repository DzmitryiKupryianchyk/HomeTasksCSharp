using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Rabbit : HerbivoreAnimal
    {
        public override void Live()
        {
            Console.Write(nameof(Rabbit));
            EatGreenery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{nameof(Rabbit)} Погрыз морковку.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(nameof(Rabbit));
            Relax();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
