using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Capibara : HerbivoreAnimal
    {
        public Capibara(string name) : base(name)
        {
        }

        public override void Live()
        {
            Console.Write(nameof(Capibara));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" " + name);
            Console.ForegroundColor = ConsoleColor.White;
            EatGreenery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{name} Пожевал травку.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(nameof(Capibara));
            Console.Write(" " + name);
            Relax();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
