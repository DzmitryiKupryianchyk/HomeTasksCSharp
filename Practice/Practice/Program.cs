using System.Text;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aString;
            int a;
            string bString;
            int b;
            int sum;
            Console.OutputEncoding = Encoding.UTF8;
            
            do
            {
                Console.WriteLine("Введите число а");
                aString = Console.ReadLine();
            } while (!Int32.TryParse(aString, out a));
            Console.WriteLine(" a Верно");
            do
            {
                Console.WriteLine("Введите число b");
                bString = Console.ReadLine();
            } while (!Int32.TryParse(bString, out b));
            Console.WriteLine("b Верно");
            sum = a + b;

            if (sum % 2 == 0 & sum % 5 == 0) Console.WriteLine($"Сумма чисел a и b = {sum}  делится на 2 и 5");
            else if (sum % 2 == 0) Console.WriteLine($"Сумма чисел a и b = {sum} делится на 2");
            else if (sum % 5 == 0) Console.WriteLine($"Сумма чисел a и b = {sum} делится на 5");
            else Console.WriteLine($"Сумма чисел a и b = {sum} не делится ни на 2 ни на 5");
            Console.ReadKey();
        }
    }
}
