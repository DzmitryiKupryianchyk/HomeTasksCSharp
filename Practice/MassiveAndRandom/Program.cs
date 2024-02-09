using System.Text;

namespace MassiveAndRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string intro = "Создать массив целочисленных элементов. Циклом занести туда рандомные числа. Реализовать перебор элементов массива используя оператор goto";
            string answer;
            bool flag = false;
            string quantityOfNumbersStr;
            int quantityOfNumbers;
            int number;
            int contain = 0;    
            List<int> listOfNumbers = new List<int>();
            Random guess = new Random();
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            foreach (char c in intro) 
            { 
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("Стартуем? Y/N");
            do 
            {
                answer = Console.ReadLine();
                if (answer == "Y" || answer == "y" || answer == "У" || answer == "у")
                {
                    flag = true;
                    Console.WriteLine(" Сколько случайных чисел нужно загадать?");
                }
                else if (answer == "N" || answer == "n" || answer == "Н" || answer == "н")
                {
                    Console.WriteLine("Завершение работы программы. Нажмите 'Enter'.");
                    return;
                }
                else Console.WriteLine("Введите корректный ответ.");
            }while (!flag);

            flag = false;

            do 
            {
                quantityOfNumbersStr = Console.ReadLine();
                if (Int32.TryParse(quantityOfNumbersStr, out quantityOfNumbers)) 
                {
                    Console.WriteLine($"Генератор составляет {quantityOfNumbers} случайных чисел.");
                    flag = true;
                    Thread.Sleep(2500);
                }
                else Console.WriteLine("Пустая срока либо неправильный формат данных. Введите целое число.");
            } while (!flag);

            for (int i = 1; i <= quantityOfNumbers;) 
            { 
                number = guess.Next();
                listOfNumbers.Add(number);
                i++;
            }
            Console.WriteLine($"Готово! Генератор загадал {quantityOfNumbers} случайных чисел.");
            mark:
            Console.WriteLine(listOfNumbers[contain]); 
            contain++;
            if (contain == quantityOfNumbers) goto mark2;
            goto mark;
            mark2:
            Console.WriteLine("Работа завершена. Для выхода из консоли нажмите 'Enter'");

        }
    }
}
