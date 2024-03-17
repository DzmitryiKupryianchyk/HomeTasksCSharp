using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod12
{
    internal class Elephant : Animal, Herbivore, IEquatable<Elephant>
    {
        private string sound;
        private string colour;
        private double size;
        public string typeH { get; set; }
        public string foodH { get; set; }
        public Elephant(string sound, string colour, double size)
        {
            this.sound = sound;
            this.colour = colour;
            this.size = size;
        }
        public void Sound() 
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(nameof(Elephant) + " ");
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
            Console.Write($"{nameof(Elephant)} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{name} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Размер - ");
            Console.Write(size);
            Console.Write(" м.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(typeH);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public void DisplayEatH()
        {
            Console.Write("Тип - ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(typeH);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(". Рацион питания - ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{foodH}.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public bool Equals(Elephant? other)
        {
            if (other.size == null)
            {
                return false;
            }
            else if (size > other.size)
            {
                double difference = size - other.size;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{nameof(Elephant)} ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{name} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("больше чем ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{other.name} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("на ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{difference} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("м.");
                Console.WriteLine();
                return false;
            }
            else if (size < other.size) 
            {
                double difference = other.size - size;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{nameof(Elephant)} ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{name} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("меньше чем ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{other.name} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("на ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{difference} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("м.");
                Console.WriteLine();
                return false;
            }
            else
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{nameof(Elephant)} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{name} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("равен ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{other.name} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return size == other.size;
        }

        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{nameof(Elephant)} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{name} ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"купается в пруду.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
