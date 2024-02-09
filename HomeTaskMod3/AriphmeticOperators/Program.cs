using System.Text;

namespace AriphmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string intro = "Имеется 3 переменные типа int x = 14, y = 1, и z = 5; Выведите значения переменных на Console после каждой операции";
            decimal x = 14;
            decimal y = 1;
            decimal z = 5;
            foreach (char c in intro) 
            { 
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();    
            x += y - x++ * z;
            Console.WriteLine("x += y - x++ * z;");
            Console.WriteLine($"x = {x}, z = {z}, y = {y}");
            Console.WriteLine();
            z = --x - y * 5;
            Console.WriteLine("z = --x - y * 5;");
            Console.WriteLine($"x = {x}, z = {z}, y = {y}");
            Console.WriteLine();
            y /= x + 5 % z;
            Console.WriteLine("y /= x + 5 % z;");
            Console.WriteLine($"x = {x}, z = {z}, y = {y}");
            Console.WriteLine();
            z = x++ + y * 5;
            Console.WriteLine("z = x++ + y * 5;");
            Console.WriteLine($"x = {x}, z = {z}, y = {y}");
            Console.WriteLine();
            x = y - x++ * z;
            Console.WriteLine("x = y - x++ * z;");
            Console.WriteLine($"x = {x}, z = {z}, y = {y}");
            Console.WriteLine();
            Console.WriteLine($"Итоговое значение z = {z}");
            Console.WriteLine("Работа программы завершена. Для выхода нажмите 'Enter'");
            Console.ReadKey();
        }
    }
}
