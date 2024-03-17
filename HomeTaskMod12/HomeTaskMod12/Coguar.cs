using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod12
{
    internal class Coguar : Animal, Carnivore
    {
        private string sound;
        private string colour;
        public string typeC { get; set; }
        public string foodC { get; set; }
        public Coguar(string sound, string colour)
        {
            this.sound = sound;
            this.colour = colour;
        }
        public void Sound()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(nameof(Coguar) + " ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(GetName() + " ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(sound);
            Console.WriteLine();
        }

        public override void DisplayAnimal()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{colour} ");
            Console.Write($"{nameof(Coguar)} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{name} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Тип - ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(typeC);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        public void DisplayEatC()
        {
            Console.Write("Тип - ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(typeC);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(". Рацион питания - ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{foodC}.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{nameof(Coguar)} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{name} ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"греется на солнышке.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
