﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeTaskMod12
{
    internal class Gorilla : Animal, Herbivore
    {

        private string sound;
        private string colour;
        public string typeH { get; set; }
        public string foodH { get; set; }
        public Gorilla(string sound, string colour)
        {
            this.sound = sound;
            this.colour = colour;
        }
        public void Sound()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(nameof(Gorilla) + " ");
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
            Console.Write($"{nameof(Gorilla)} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{name} ");
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
        public override void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{nameof(Gorilla)} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{name} ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"залез на дерево.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
