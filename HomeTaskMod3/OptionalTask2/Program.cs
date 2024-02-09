using System.Text;

namespace OptionalTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string intro = "Ввести трехзначное число. Опреднлить в нем количество едениц, десятков, сотен. Найти произведение и сумму всех его чисел.";
            string argumentStr;
            int argument;
            int ones;
            int tens;
            int hundreds;
            int sum;
            int multiply;
            List<int> nums = new List<int>();
            foreach (char c in intro) 
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("Введите число от 100 до 999");
            argumentStr = Console.ReadLine();
            if (Int32.TryParse(argumentStr, out argument) & argument >= 100 & argument <= 999)
            {
                Console.WriteLine("Число введено корректно.");
                Thread.Sleep(1500);

            }
            else
            {
                do
                {
                    Console.WriteLine("Введен неверный формат данных либо пустая строка. Попробуйте еще раз. Допустимо только целое число от 100 до 999");
                    argumentStr = Console.ReadLine();
                } while (!Int32.TryParse(argumentStr, out argument) & argument <= 100 & argument >= 999);
            }
            foreach (char c in argumentStr) 
            {
                int temp = Convert.ToInt32(Convert.ToString(c));
                nums.Add(temp);
            }
            ones = nums[2];
            tens = nums[1];
            hundreds = nums[0];
            sum = ones + tens + hundreds;
            multiply = hundreds * tens * ones;
            Console.WriteLine("Число содержит: ");
            Thread.Sleep(500);
            Console.WriteLine("Сотен - " + hundreds);
            Thread.Sleep(500);
            Console.WriteLine("Десятков - " + tens);
            Thread.Sleep(500);
            Console.WriteLine("Единиц - " + ones);
            Thread.Sleep(500);
            Console.WriteLine($"{hundreds} + {tens} + {ones} = " + sum);
            Thread.Sleep(500);
            Console.WriteLine($"{hundreds} * {tens} * {ones} = " + multiply);
            Thread.Sleep(500);
            Console.WriteLine("Работа программы завершена. Для выхода нажмите 'Enter'");
            Console.ReadKey();
        }
    }
}
