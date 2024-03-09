using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Quokka : HerbivoreAnimal
    {
        public override void Live()
        {
            Console.Write(nameof(Quokka));
            EatGreenery();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{nameof(Quokka)} Поел ягод.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(nameof(Quokka));
            Relax();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
