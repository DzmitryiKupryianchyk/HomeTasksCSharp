using System.Reflection;
using System.Text;
using System.Text.Unicode;

namespace HerbivorePredatorZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string intro = "Реализовать структуру классов с животными, разделить их на хищников и травоядных, переопределить виртуальный метод 'Live' согласно поведению видов. Расселить в зоопарке раздельно хищников и травоядных";
            foreach (char c in intro) 
            {
                Console.Write(c);
                //Thread.Sleep(20);
            }
            Console.WriteLine();

            Lion simba = new Lion();
            Tiger sharhan = new Tiger();
            Wolf balto = new Wolf();
            Bear balu = new Bear();

            Deer bambi = new Deer();
            Rabbit rodger = new Rabbit();
            Capibara capibara = new Capibara();
            Quokka quokka = new Quokka();

            Zoo zoo = new Zoo();
            mark:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Нажмите 1 чтобы вызвать 'Live'.");
            Console.WriteLine("Нажмите 2 чтобы вызвать заселить животных в зоопарк.");
            Console.WriteLine("Нажмите 3 чтобы посмотреть всех обитателей зоопарка.");
            Console.WriteLine("Нажмите 4 чтобы выпустить одного из питомцев на волю.");
            Console.WriteLine("Нажмите 5 чтобы выпустить животных погулять.");
            Console.WriteLine("Нажмите 'esc' чтобы завершить работу.");
            Console.ForegroundColor = ConsoleColor.White;
            var choice = ConsoleKey.Enter;
            while (choice != ConsoleKey.Escape)
            {
                choice = Console.ReadKey().Key;
                Console.WriteLine();
                switch (choice)
                {
                    case ConsoleKey.D1:
                        simba.Live();
                        Thread.Sleep(1000);
                        sharhan.Live();
                        Thread.Sleep(1000);
                        balto.Live();
                        Thread.Sleep(1000);
                        balu.Live();
                        Thread.Sleep(1000);
                        bambi.Live();
                        Thread.Sleep(1000);
                        rodger.Live();
                        Thread.Sleep(1000);
                        capibara.Live();
                        Thread.Sleep(1000);
                        quokka.Live();
                        goto mark;
                    case ConsoleKey.D2:
                        zoo.Add(simba);
                        Thread.Sleep(20);
                        zoo.Add(sharhan);
                        Thread.Sleep(20);
                        zoo.Add(balto);
                        Thread.Sleep(20);
                        zoo.Add(balu);
                        Thread.Sleep(20);
                        zoo.Add(bambi);
                        Thread.Sleep(20);
                        zoo.Add(rodger);
                        Thread.Sleep(20);
                        zoo.Add(capibara);
                        Thread.Sleep(20);
                        zoo.Add(quokka);
                        goto mark;
                    case ConsoleKey.D3:
                        zoo.ToSeeZoo();
                        goto mark;
                    case ConsoleKey.D4:
                        zoo.ToReleaseAnAnimal();
                        goto mark;
                    case ConsoleKey.D5:
                        zoo.LetOutForAWalk();
                        goto mark;
                    case ConsoleKey.Escape:
                        break;
                }
            }
            Console.WriteLine("РPабота завершена.");
        }
    }
}
