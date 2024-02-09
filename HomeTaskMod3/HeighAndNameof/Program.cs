using System.Text;

namespace HeighAndNameof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string intro = "Создать переменную в которую записать свой рост и вывести в консоль название переменной и значение. Используйте оператор nameof.";
            string heighString;
            double heigh;
            foreach (char c in intro)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Введите свой рост");

            heighString = Console.ReadLine();
            if (double.TryParse(heighString, out heigh))
            {
                Console.WriteLine("Число введено корректно.");
                Thread.Sleep(1500);
            }
            else
            {
                do
                {
                    Console.WriteLine("Введен неверный формат данных либо пустая строка. Попробуйте еще раз. Допустимо только целое или дробное число");
                    heighString = Console.ReadLine();
                } while (!double.TryParse(heighString, out heigh));
            }
            Console.WriteLine("Принято. Ваш рост составляет " + nameof(heigh) + "=" + heigh);
            Console.WriteLine("Работа программы завершена. Для выхода нажмите 'Enter'");
            Console.ReadKey();
        }
    }
}
