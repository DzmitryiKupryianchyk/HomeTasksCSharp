using System.Text;

namespace IsTheNumberEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            String intro = "Введите целое число с консоли и я скажу четное оно или нет.";
            string answer;
            string numberString;
            int number;
            //int iterationCount = 0;
            List<int> numbers = new List<int>();

            foreach (char c in intro) 
            { 
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
            Thread.Sleep(1000);

            do
            {
                Console.WriteLine("Введите целое число");
                numberString = Console.ReadLine();
                if (Int32.TryParse(numberString, out number))
                {
                    if (number % 2 == 0) 
                    { 
                        Console.WriteLine($"Число {number} четное.");
                    }
                    else Console.WriteLine($"Число {number} нечетное.");
                    //iterationCount++;
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Введен неверный формат данных либо пустая строка. Попробуйте еще раз. Допустимы только целые числа");
                        numberString = Console.ReadLine();
                    } while (!Int32.TryParse(numberString, out number));
                }
                numbers.Add(number);
                Console.WriteLine("Добавить еще одно число? Нажмите Y если ДА, или любую другую клавишу если НЕТ");
                answer = Console.ReadLine();
            }
            while (answer == "Y" || answer == "y");
            Thread.Sleep(1000);
            Console.WriteLine("Работа программы завершена. Для выхода из консоли нажмите 'Enter'");

        }
    }
}
