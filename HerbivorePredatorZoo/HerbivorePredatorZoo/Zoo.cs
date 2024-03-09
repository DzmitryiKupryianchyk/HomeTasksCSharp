using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HerbivorePredatorZoo
{
    
    internal class Zoo
    {
        List<Predator> aivaryForPredators = new List<Predator>();
        List<HerbivoreAnimal> aivaryForHerbivore = new List<HerbivoreAnimal>();

        public void Add(Animal animal) 
        { 
            Type type = animal.GetType();
            
            if (type.BaseType == typeof(Predator))
            {
                foreach (Predator predator in aivaryForPredators) 
                {
                    if (predator.Equals(animal)) 
                    {
                        Console.Write($"{type.Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(animal.name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" уже содержится в зоопарке. ");
                        Console.WriteLine();
                        goto mark;
                    }
                }
                Console.Write($"{type.Name} ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(animal.name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" поселен в вольер для хищников. ");
                Console.WriteLine();
                aivaryForPredators.Add((Predator)animal);
            }
            else if (type.BaseType == typeof(HerbivoreAnimal)) 
            {
                foreach (HerbivoreAnimal herbivoreAnimal in aivaryForHerbivore)
                {
                    if (herbivoreAnimal.Equals(animal))
                    {
                        Console.Write($"{type.Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(animal.name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" уже содержится в зоопарке. ");
                        Console.WriteLine();
                        goto mark;
                    }
                }
                aivaryForHerbivore.Add((HerbivoreAnimal)animal);
                Console.Write($"{type.Name} ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(animal.name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" поселен в вольер для травоядных. ");
                Console.WriteLine();
            }
            mark:;
        }
        public void ToSeeZoo() 
        { 
            Console.WriteLine();
            if (aivaryForPredators.Count == 0) { Console.WriteLine("Вольер для хищников пуст:("); }
            else
            {
                Console.WriteLine("В вольере с хищниками живут:");
                int iterCount = 1;
                foreach (Predator animal in aivaryForPredators)
                {
                    Console.Write(iterCount + "-" + animal.GetType().Name +" ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(animal.name + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                    iterCount++;
                }
                Console.WriteLine();
            }
            if (aivaryForHerbivore.Count == 0) { Console.WriteLine("Вольер для травоядных пуст:("); }
            else
            {
                int iterCount = 1;
                Console.WriteLine("В вольере с травоядными живут:");
                foreach (HerbivoreAnimal animal in aivaryForHerbivore)
                {
                    Console.Write(iterCount + "-" + animal.GetType().Name + " ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(animal.name + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                    iterCount++;
                }
                Console.WriteLine();
            }
        }
        public void ToReleaseAnAnimal()
        {
            if (aivaryForPredators.Count == 0 && aivaryForHerbivore.Count == 0) { Console.WriteLine("Зоопарк пуст:("); }
            else
            {
                Console.WriteLine("Кого отпустим на свободу?");
                Thread.Sleep(1000);
                int iterCount = 1;
                foreach (Predator animal in aivaryForPredators)
                {
                    Console.Write(iterCount + "-" + animal.GetType().Name + " ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(animal.name + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                    iterCount++;
                }
                Console.WriteLine();
                foreach (HerbivoreAnimal animal in aivaryForHerbivore)
                {
                    Console.Write(iterCount + "-" + animal.GetType().Name + " ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(animal.name + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                    iterCount++;
                }
                Console.WriteLine();

                var choice = Console.ReadKey().Key;
                Console.WriteLine();
                switch (choice)
                {
                    case ConsoleKey.D1:
                        Console.Write($"{aivaryForPredators[0].GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{aivaryForPredators[0].name} ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"выпущен на свободу.");
                        Console.WriteLine();
                        aivaryForPredators.RemoveAt(0);
                        break;
                    case ConsoleKey.D2:
                        Console.Write($"{aivaryForPredators[1].GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{aivaryForPredators[1].name} ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"выпущен на свободу.");
                        Console.WriteLine();
                        aivaryForPredators.RemoveAt(1);
                        break;
                    case ConsoleKey.D3:
                        Console.Write($"{aivaryForPredators[2].GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{aivaryForPredators[2].name} ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"выпущен на свободу.");
                        Console.WriteLine();
                        aivaryForPredators.RemoveAt(2);
                        break;
                    case ConsoleKey.D4:
                        Console.Write($"{aivaryForPredators[3].GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{aivaryForPredators[3].name} ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"выпущен на свободу.");
                        Console.WriteLine();
                        aivaryForPredators.RemoveAt(3);
                        break;
                    case ConsoleKey.D5:
                        Console.Write($"{aivaryForPredators[4].GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{aivaryForPredators[4].name} ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"выпущен на свободу.");
                        Console.WriteLine();
                        aivaryForPredators.RemoveAt(4);
                        break;
                    case ConsoleKey.D6:
                        Console.Write($"{aivaryForHerbivore[0].GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{aivaryForHerbivore[0].name} ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"выпущен на свободу.");
                        Console.WriteLine();
                        aivaryForHerbivore.RemoveAt(0);
                        break;
                    case ConsoleKey.D7:
                        Console.Write($"{aivaryForHerbivore[1].GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{aivaryForHerbivore[1].name} ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"выпущен на свободу.");
                        Console.WriteLine();
                        aivaryForHerbivore.RemoveAt(1);
                        break;
                    case ConsoleKey.D8:
                        Console.Write($"{aivaryForHerbivore[2].GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{aivaryForHerbivore[2].name} ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"выпущен на свободу.");
                        Console.WriteLine();
                        aivaryForHerbivore.RemoveAt(2);
                        break;
                    case ConsoleKey.D9:
                        Console.Write($"{aivaryForHerbivore[3].GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{aivaryForHerbivore[3].name} ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"выпущен на свободу.");
                        Console.WriteLine();
                        aivaryForHerbivore.RemoveAt(3);
                        break;
                    case ConsoleKey.Escape:
                        break;
                }
            }
        }
        public void LetOutForAWalk() 
        {
            if (aivaryForPredators.Count == 0) { Console.WriteLine("Вольер для хищников пуст:("); }
            else
            {
                foreach (var ai in aivaryForPredators)
                {
                    ai.Rest();
                    Thread.Sleep(500);
                }
            }
            if (aivaryForHerbivore.Count == 0) { Console.WriteLine("Вольер для травоядных пуст:("); }
            else
            {
                foreach (var ai in aivaryForHerbivore)
                {
                    ai.Rest();
                    Thread.Sleep(500);
                }
            }
        }
    }
}
