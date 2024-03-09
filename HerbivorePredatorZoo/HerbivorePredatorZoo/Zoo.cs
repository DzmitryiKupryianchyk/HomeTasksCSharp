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
                        Console.WriteLine($"{type.Name} уже содержится в зоопарке.");
                        goto mark;
                    }
                }
                Console.WriteLine($"{type.Name} поселен в вольер для хищников.");
                aivaryForPredators.Add((Predator)animal);
            }
            else if (type.BaseType == typeof(HerbivoreAnimal)) 
            {
                foreach (HerbivoreAnimal herbivoreAnimal in aivaryForHerbivore)
                {
                    if (herbivoreAnimal.Equals(animal))
                    {
                        Console.WriteLine($"{type.Name} уже содержится в зоопарке.");
                        goto mark;
                    }
                }
                aivaryForHerbivore.Add((HerbivoreAnimal)animal);
                Console.WriteLine($"{type.Name} поселен в вольер для травоядных.");
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
                    Console.Write(iterCount + "-" + animal.GetType().Name + " ");
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
                    iterCount++;
                }
                Console.WriteLine();
                foreach (HerbivoreAnimal animal in aivaryForHerbivore)
                {
                    Console.Write(iterCount + "-" + animal.GetType().Name + " ");
                    iterCount++;
                }
                Console.WriteLine();

                var choice = Console.ReadKey().Key;
                Console.WriteLine();
                switch (choice)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine($"{aivaryForPredators[0].GetType().Name} выпущен на свободу.");
                        aivaryForPredators.RemoveAt(0);
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine($"{aivaryForPredators[1].GetType().Name} выпущен на свободу.");
                        aivaryForPredators.RemoveAt(1);
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine($"{aivaryForPredators[2].GetType().Name} выпущен на свободу.");
                        aivaryForPredators.RemoveAt(2);
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine($"{aivaryForPredators[3].GetType().Name} выпущен на свободу.");
                        aivaryForPredators.RemoveAt(3);
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine($"{aivaryForHerbivore[0].GetType().Name} выпущен на свободу.");
                        aivaryForHerbivore.RemoveAt(0);
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine($"{aivaryForHerbivore[1].GetType().Name} выпущен на свободу.");
                        aivaryForHerbivore.RemoveAt(1);
                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine($"{aivaryForHerbivore[2].GetType().Name} выпущен на свободу.");
                        aivaryForHerbivore.RemoveAt(2);
                        break;
                    case ConsoleKey.D8:
                        Console.WriteLine($"{aivaryForHerbivore[3].GetType().Name} выпущен на свободу.");
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
