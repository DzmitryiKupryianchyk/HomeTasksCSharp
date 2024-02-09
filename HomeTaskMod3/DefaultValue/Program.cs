using System.Text;

namespace DefaultValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int number = 10;
            char letter = 'A';
            bool statement = true;
            string hello = "Hello world!";
            string intro = "С помощью оператора default вывести в консоль дефолтные значения для всех числовых типов данных + типа  int?, типа string, char, bool";

            foreach (char c in intro) 
            { 
                Console.Write(c);
                Thread.Sleep(15);
            }
            Console.WriteLine();
            Console.WriteLine("Дефолтное значение для типа bool = " + default(bool));
            Console.WriteLine("Дефолтное значение для типа byte = " + default(byte));
            Console.WriteLine("Дефолтное значение для типа sbyte = " + default(sbyte));
            Console.WriteLine("Дефолтное значение для типа char = " + default(char));
            Console.WriteLine("Дефолтное значение для типа decimal = " + default(decimal));
            Console.WriteLine("Дефолтное значение для типа double = " + default(double));
            Console.WriteLine("Дефолтное значение для типа float = " + default(float));
            Console.WriteLine("Дефолтное значение для типа int = " + default(int));
            Console.WriteLine("Дефолтное значение для типа uint = " + default(uint));
            Console.WriteLine("Дефолтное значение для типа long = " + default(long));
            Console.WriteLine("Дефолтное значение для типа ulong = " + default(ulong));
            Console.WriteLine("Дефолтное значение для типа object = " + default(object));
            Console.WriteLine("Дефолтное значение для типа short = " + default(short));
            Console.WriteLine("Дефолтное значение для типа ushort = " + default(ushort));
            Console.WriteLine("Дефолтное значение для типа string = " + default(string));

            Console.WriteLine("Работа программы завершена. Для выхода нажмите 'Enter'");
            Console.ReadKey();
        }
    }
}
