using System;
using System.Text;

namespace HomeTaskMod12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string typeHerb = "травоядное";
            string typeCarn = "плотоядное";
            string foodHerb = "фрукты, овощи, зелень";
            string foodCarn = "мясо и рыба";
            string intro = "Используя структуру из задания создать класс Zoo который может принимать плотоядных животных в один загон, а травоядных в другой, использовать интерфейсы.Добавить слону возможность сравнивать какой слон больше за счет нового поля Size и реализации интерфейса Iequatable";
            List<Animal> animals = new List<Animal>();
            Zoo zoo = new Zoo();
            foreach (char c in intro) 
            { 
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();

            string elephantSound = "Дудит хоботом";
            string elephantColour = "серый";
            double size = 2.9;
            Elephant sam = new Elephant(elephantSound, elephantColour, size) {typeH = typeHerb, foodH = foodHerb };
            sam.SetName(nameof(sam));
            sam.SetNumOfLegs(4);
            animals.Add(sam);
            

            string elephant2Sound = "Дудит хоботом";
            string elephant2Colour = "серый";
            double size2 = 3.3;
            Elephant boo = new Elephant(elephant2Sound, elephant2Colour, size2) { typeH = typeHerb, foodH = foodHerb };
            boo.SetName(nameof(boo));
            boo.SetNumOfLegs(4);
            animals.Add(boo);

            string elephant3Sound = "Дудит хоботом";
            string elephant3Colour = "серый";
            double size3 = 3.5;
            Elephant mouse = new Elephant(elephant3Sound, elephant3Colour, size3) { typeH = typeHerb, foodH = foodHerb };
            mouse.SetName(nameof(mouse));
            mouse.SetNumOfLegs(4);
            animals.Add(mouse);

            string elephant4Sound = "Дудит хоботом";
            string elephant4Colour = "серый";
            double size4 = 2.7;
            Elephant donkie = new Elephant(elephant4Sound, elephant4Colour, size4) { typeH = typeHerb, foodH = foodHerb };
            donkie.SetName(nameof(donkie));
            donkie.SetNumOfLegs(4);
            animals.Add(donkie);

            string elephant5Sound = "Дудит хоботом";
            string elephant5Colour = "серый";
            double size5 = 3.1;
            Elephant jango = new Elephant(elephant5Sound, elephant5Colour, size5) { typeH = typeHerb, foodH = foodHerb };
            jango.SetName(nameof(jango));
            jango.SetNumOfLegs(4);
            animals.Add(jango);

            string elephant6Sound = "Дудит хоботом";
            string elephant6Colour = "серый";
            double size6 = 2.9;
            Elephant burger = new Elephant(elephant6Sound, elephant6Colour, size6) { typeH = typeHerb, foodH = foodHerb };
            burger.SetName(nameof(burger));
            burger.SetNumOfLegs(4);
            animals.Add(burger);

            string catSound = "Мурчит";
            string catColour = "белый";
            Cat tom = new Cat(catSound, catColour) {typeC = typeCarn, foodC = foodCarn };
            tom.SetName(nameof(tom));
            tom.SetNumOfLegs(4);
            animals.Add(tom);

            string bearSound = "Рычит";
            string bearColour = "коричневый";
            Bear balu = new Bear(bearSound, bearColour) { typeC = typeCarn, foodC = foodCarn, typeH = typeHerb, foodH = foodHerb };
            balu.SetName(nameof(balu));
            balu.SetNumOfLegs(4);
            animals.Add(balu);

            string capibaraSound = "Пищит";
            string capibaraColor = "Коричневый";
            Capibara stewie = new Capibara (capibaraSound, capibaraColor) { typeH = typeHerb, foodH = foodHerb };
            stewie.SetName(nameof(stewie));
            stewie.SetNumOfLegs(4);
            animals.Add(stewie);

            string lionSound = "Грозно рычит";
            string lionColour = "бежевый";
            Lion simba = new Lion(lionSound, lionColour) { typeC = typeCarn, foodC = foodCarn };
            simba.SetName(nameof(simba));
            simba.SetNumOfLegs(4);
            animals.Add(simba);

            string coguarSound = "рычит";
            string coguarColour = "черный";
            Coguar bagira = new Coguar(coguarSound, coguarColour) { typeC = typeCarn, foodC = foodCarn };
            bagira.SetName(nameof(bagira));
            bagira.SetNumOfLegs(4);
            animals.Add(bagira);

            string gorillaSound = "Бъет себя в грудь";
            string gorillaColor = "черный";
            Gorilla caesar = new Gorilla(gorillaSound, gorillaColor) { typeH = typeHerb, foodH = foodHerb };
            caesar.SetName(nameof(caesar));
            caesar.SetNumOfLegs(4);
            animals.Add(caesar);
        mark:
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Нажмите 1 чтобы показать животных.");
            Console.WriteLine("Нажмите 2 чтобы заселить животных в зоопарк.");
            Console.WriteLine("Нажмите 3 чтобы животные подали голос.");
            Console.WriteLine("Нажмите 4 чтобы посмотреть всех обитателей зоопарка.");
            Console.WriteLine("Нажмите 5 чтобы выпустить животных погулять.");
            Console.WriteLine("Нажмите 6 чтобы сравнить слонов.");
            Console.WriteLine("Нажмите 'esc' чтобы завершить работу.");
            Console.ForegroundColor = ConsoleColor.White;

            //zoo.CompareElephants();

            var choice = ConsoleKey.Enter;
            while (choice != ConsoleKey.Escape)
            {
                choice = Console.ReadKey().Key;
                Console.WriteLine();
                switch (choice)
                {
                    case ConsoleKey.D1:
                        foreach (var b in animals)
                        {
                            b.DisplayAnimal();
                        }
                        goto mark;
                    case ConsoleKey.D2:
                        foreach (var b in animals)
                        {
                            zoo.AddToZoo(b);
                        }
                        goto mark;
                    case ConsoleKey.D3:
                        zoo.GiveVoice();
                        goto mark;
                    case ConsoleKey.D4:
                        zoo.ToSeeZoo();
                        goto mark;
                    case ConsoleKey.D5:
                        zoo.LetOutForAWalk();
                        goto mark;
                    case ConsoleKey.D6:
                        zoo.CompareElephants();
                        goto mark;
                    case ConsoleKey.Escape:
                        break;
                }
            }
            Console.WriteLine("0Работа завершена");
            Console.ReadKey();
        }
    }
}
