using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Deer : HerbivoreAnimal
    {
        public Deer(string name) : base(name)
        {
        }

        public override void Live()
        {
            Console.Write(nameof(Deer));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" " + name);
            Console.ForegroundColor = ConsoleColor.White;
            EatGreenery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{name} Пощипал травку.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(nameof(Deer));
            Console.Write(" " + name);
            Relax();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
