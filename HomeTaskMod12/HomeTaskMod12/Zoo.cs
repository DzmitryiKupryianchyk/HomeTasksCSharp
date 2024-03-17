using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod12
{
    internal class Zoo
    {
        List<Animal> carnivores = new List<Animal>();
        List<Animal> herbivores = new List<Animal>();

        public void AddToZoo(Animal animal) 
        {
            string type = animal.GetType().Name;

            if (animal is Herbivore && animal is Carnivore)
            {
                Console.WriteLine($"{animal.GetType().Name} относится как к плотоядным, так и к травоядным. В какой вольер желаете поселить?");
                Thread.Sleep( 1000 );
                Console.Write("1 - поселить в вольер к ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("хищникам ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("2 - к ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("травоядным");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                var choice = Console.ReadKey().Key;
                Console.WriteLine();
                switch (choice)
                {
                    case ConsoleKey.D1:
                        carnivores.Add(animal);
                        Console.Write($"{animal.GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(animal.GetName());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" поселен в вольер для ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("хищников. ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D2:
                        herbivores.Add(animal);
                        Console.Write($"{animal.GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(animal.GetName());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" поселен в вольер для ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("травоядных.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        break;
                }
            }

            else if (animal is Herbivore)
            {
                foreach (Animal herb in herbivores)
                {
                    if (herb.Equals(animal))
                    {
                        Console.Write($"{animal.GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(animal.GetName());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" уже содержится в зоопарке.");
                        Console.WriteLine();
                        goto mark;
                    }
                }
                Console.Write($"{animal.GetType().Name} ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(animal.GetName());
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" поселен в вольер для ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("травоядных.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                herbivores.Add(animal);
            }
            else if (animal is Carnivore)
            {
                foreach (Animal predator in carnivores) 
                {
                    if (predator.Equals(animal)) 
                    {
                        Console.Write($"{animal.GetType().Name} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(animal.GetName());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" уже содержится в зоопарке. ");
                        Console.WriteLine();
                        goto mark;
                    }
                }
                Console.Write($"{animal.GetType().Name} ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(animal.GetName());
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" поселен в вольер для ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("хищников. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                carnivores.Add(animal);
            }
            
        mark:;
        }
        public void ToSeeZoo()
        {
            Console.WriteLine();
            if (carnivores.Count == 0) { Console.WriteLine("Вольер для хищников пуст:("); }
            else
            {
                Console.WriteLine("В вольере с хищниками живут:");
                int iterCount = 1;
                foreach (Animal animal in carnivores)
                {
                    
                    Console.Write(iterCount + "-" + animal.GetType().Name + " ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(animal.GetName() + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    if (animal is Carnivore && animal is Herbivore)
                    {
                        Carnivore cAnimal = (Carnivore)animal;
                        cAnimal.DisplayEatC();
                        Herbivore hAnimal = (Herbivore)animal;
                        hAnimal.DisplayEatH();
                    }
                    else if (animal is Carnivore)
                    {
                        Carnivore cAnimal = (Carnivore)animal;
                        cAnimal.DisplayEatC();
                    }
                    
                    iterCount++;
                }
                Console.WriteLine();
            }
            if (herbivores.Count == 0) { Console.WriteLine("Вольер для травоядных пуст:("); }
            else
            {
                int iterCount = 1;
                Console.WriteLine("В вольере с травоядными живут:");
                foreach (Animal animal in herbivores)
                {
                    Console.Write(iterCount + "-" + animal.GetType().Name + " ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(animal.GetName() + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    if (animal is Carnivore && animal is Herbivore)
                    {
                        Carnivore cAnimal = (Carnivore)animal;
                        cAnimal.DisplayEatC();
                        Herbivore hAnimal = (Herbivore)animal;
                        hAnimal.DisplayEatH();
                    }
                    else if (animal is Herbivore)
                    {
                        Herbivore cAnimal = (Herbivore)animal;
                        cAnimal.DisplayEatH();
                    }
                    
                    iterCount++;
                }
                Console.WriteLine();
            }
        }
        public void GiveVoice() 
        {
            foreach (var animal in herbivores) 
            {

                if (animal is Elephant)
                {
                    Elephant elephant = (Elephant)animal; elephant.Sound();
                }
                else if (animal is Bear)
                {
                    Bear bear = (Bear)animal; bear.Sound();
                }
                else if (animal is Capibara)
                {
                    Capibara capibara = (Capibara)animal; capibara.Sound();
                }
                else if (animal is Gorilla)
                {
                    Gorilla gorilla = (Gorilla)animal; gorilla.Sound();
                }
            }
            foreach (var animal in carnivores) 
            {
                if (animal is Cat)
                {
                    Cat cat = (Cat)animal; cat.Sound();
                }
                else if (animal is Bear)
                {
                    Bear bear = (Bear)animal; bear.Sound();
                }
                else if (animal is Lion)
                {
                    Lion lion = (Lion)animal; lion.Sound();
                }
                else if (animal is Coguar)
                {
                    Coguar coguar = (Coguar)animal; coguar.Sound();
                }
               
            }
        }
        public void LetOutForAWalk()
        {
            if (carnivores.Count == 0) { Console.WriteLine("Вольер для хищников пуст:("); }
            else
            {
                foreach (var ai in carnivores)
                {
                    ai.Rest();
                    Thread.Sleep(500);
                }
            }
            if (herbivores.Count == 0) { Console.WriteLine("Вольер для травоядных пуст:("); }
            else
            {
                foreach (var ai in herbivores)
                {
                    ai.Rest();
                    Thread.Sleep(500);
                }
            }
        }
        public void CompareElephants() 
        {
            List<Elephant> elephants = new List<Elephant>();
            foreach (Animal animal in herbivores)
            {
                if (animal is Elephant) 
                {
                    Elephant elephant = (Elephant)animal; 
                    elephants.Add(elephant);
                }
            } 
            int i = 0;
            int b = elephants.Count - 1;
            foreach (Elephant elephant in elephants) 
            {
                if (i == b) { elephant.Equals(elephants[0]); }
                else { elephant.Equals(elephants[++i]); --i; }
                i++;
            }
        }
    }
}
