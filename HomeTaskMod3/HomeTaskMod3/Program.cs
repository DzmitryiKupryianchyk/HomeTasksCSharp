using System.Text;

namespace HomeTaskMod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal S;
            string RString;
            decimal R;
            string IString;
            decimal I;
            const decimal pi = 3.141592653m;
            string introduction = "Рассчитать площать поверхности круглого конуса по формуле S = pi * r(r + I)";
            foreach (char c in introduction)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
            Console.WriteLine("Введите радиус конуса");
            RString = Console.ReadLine();
            if (decimal.TryParse(RString, out R))
            {
                Console.WriteLine("Число введено корректно.");
                Thread.Sleep(1500);
            }
            else
            {
                do
                {
                    Console.WriteLine("Введен неверный формат данных либо пустая строка. Попробуйте еще раз. Допустимо только целое либо дробное число");
                    RString = Console.ReadLine();
                } while (!decimal.TryParse(RString, out R));
            }
            Console.WriteLine("Введите образующую");

            IString = Console.ReadLine();
            if (decimal.TryParse(IString, out I))
            {
                Console.WriteLine("Число введено корректно.");
                Thread.Sleep(1500);
            }
            else
            {
                do
                {
                    Console.WriteLine("Введен неверный формат данных либо пустая строка. Попробуйте еще раз. Допустимо только целое либо дробное число");
                    IString = Console.ReadLine();
                } while (!decimal.TryParse(IString, out I));
            }
            Console.WriteLine("Расчет по формуле: S = pi * r(r + I)");
            S = pi * R * ( R + I);
            Thread.Sleep(1000);
            Console.WriteLine($"Готово. Площадь сечения конуса = {S} Для выхода нажмите 'Enter'");
            Console.ReadKey();
        }
    }
}
