﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    internal class Lion : Predator
    {
        public Lion(string name) : base(name)
        {
        }

        public override void Live()
        {
            Console.Write(nameof(Lion));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" " + name);
            Console.ForegroundColor = ConsoleColor.White;
            Hunt();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{name} Поймал зебру.");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(nameof(Lion));
            Console.Write(" " + name);
            Relax();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
