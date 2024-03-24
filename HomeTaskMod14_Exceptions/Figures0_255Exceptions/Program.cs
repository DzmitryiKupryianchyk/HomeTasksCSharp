using System.Text;

namespace Figures0_255Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            string[] input;
            bool correct = false;
            Console.OutputEncoding = Encoding.UTF8;
            //double result;
            string intro = "Создать приложение, запрашивающее два значения от 0 до 255 и выдает результат деления одного на другое. Предусмотреть и обработать всевозможные исключения.";
            foreach (char c in intro) 
            { 
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(c);
                //Thread.Sleep(20);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            Console.WriteLine("Введите числа 'a' и 'b' . Для разделителя используйте пробел.");
            while (!correct)
            {
                try
                {
                    input = Console.ReadLine().Split(' ');

                    a = int.Parse(input[0]);
                    b = int.Parse(input[1]);
                    if (a < 0 || a > 255 || b < 0 || b > 255)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    double result = a / b;
                    Console.WriteLine($"{a} / {b} = {result}");
                    correct = true;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (IndexOutOfRangeException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
