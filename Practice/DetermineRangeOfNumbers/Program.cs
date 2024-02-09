using System.Text;

namespace DetermineRangeOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string argumentString;
            int argument;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введите целое число");
            argumentString = Console.ReadLine();
            if (Int32.TryParse(argumentString, out argument))
            {
                Console.WriteLine("Число введено корректно.");
                Thread.Sleep(1500);
            }
            else
            {
                do
                {
                    Console.WriteLine("Введен неверный формат данных либо пустая строка. Попробуйте еще раз. Допустимо только целое число");
                    argumentString = Console.ReadLine();
                } while (!Int32.TryParse(argumentString, out argument));
            }

            if (argument >= 0 & argument <= 30) { Console.WriteLine($"Число {argument} находится в промежутке от 0 до 30"); }
            if (argument >= 31 & argument <= 60) { Console.WriteLine($"Число {argument} находится в промежутке от 31 до 60"); }
            if (argument >= 61 & argument <= 100) { Console.WriteLine($"Число {argument} находится в промежутке от 61 до 100"); }
            else { Console.WriteLine($"число {argument} находится за пределами трех обозначеных промежутков"); }
            Console.ReadKey();
        }
    }
}
