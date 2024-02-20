using System.Text;
using MyLibrary;
namespace HomeTask1Mod7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int len = numbers.Length;

            Console.Write($"Массив {nameof(numbers)} имеет значения: ");
            foreach (int i in numbers)
            {
                Console.Write(i);
                Console.Write("-");
                Thread.Sleep(50);
            }
            Console.WriteLine();

            ArrayWorker lib = new ArrayWorker(numbers, len);
            lib.ArrayInv();
            lib.OutputToConsole();

            Console.ReadKey();
        }
    }
}
