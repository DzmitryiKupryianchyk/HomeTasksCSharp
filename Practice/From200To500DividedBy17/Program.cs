using System.Text;

namespace From200To500DividedBy17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string intro = "В промежутке от 200 до 500 найти числа, которые делятся на 17 без остатка";
            int i = 200;
            List<int> listOfNumbers = new List<int>();
            foreach (char c in intro) 
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            while (i>= 200 & i<=500) 
            {
                
                if (i % 17 == 0) 
                {
                    Console.WriteLine($"Число {i} делится на 17 без остатка");
                    listOfNumbers.Add(i);
                    Thread.Sleep(100);
                }
                i++;
            }
            Console.WriteLine($"Числа, которые делятся без остатка в промежутке от 200 до 500: {string.Join(",", listOfNumbers)}");
            Console.ReadKey();
        }
    }
}
