using System.Text;
using MyLibrary;
namespace HomeTask2Mod7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string rS, hS;
            double r = 0; double h = 0;
            string intro = "Рассчитать площадь поверхности основания и полную площадь.";
            foreach (char c in intro)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.WriteLine("Введите радиус конуса.");
            rS = Console.ReadLine();
            if (double.TryParse(rS, out r))
            {
                Console.WriteLine("Принято.");
                Thread.Sleep(1500);
            }
            else
            {
                do
                {
                    Console.WriteLine("Введен неверный формат данных либо пустая строка. Попробуйте еще раз. Допустимы только целые и дробные числа.");
                    rS = Console.ReadLine();
                } while (!double.TryParse(rS, out r));
            }
            Console.WriteLine("Введите высоту конуса.");

            hS = Console.ReadLine();
            if (double.TryParse(hS, out h))
            {
                Console.WriteLine("Принято.");
                Thread.Sleep(1500);
            }
            else
            {
                do
                {
                    Console.WriteLine("Введен неверный формат данных либо пустая строка. Попробуйте еще раз. Допустимы только целые и дробные числа.");
                    hS = Console.ReadLine();
                } while (!double.TryParse(hS, out h));
            }
            Cone obj = new Cone(r, h);
            obj.SurfaceArea();
            obj.TotalArea();
            obj.OutputInConsole();
            Console.ReadKey();
        }
    }
}
