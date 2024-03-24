using System.Text;

namespace MyUniqueException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            bool finish = false;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            StringWorker worker = new StringWorker();
            string intro = "Разработать класс описывающий уникальное для вашего приложения исключение. (Методы нашего приложения вызывают исключение, когда в качестве аргумента типа string приходит пустая строка.) Разработать класс, в котором будет вызываться разработанное ранее исключение. В классе Program реализовать обработку исключение таким образом, чтобы в зависимости от перехваченного исключения выводилось соответстующее сообщение. Создать ситуацию при которой будет обработано созданное ранее исключение.";
            foreach (char c in intro)
            {
                Console.Write(c);
                //Thread.Sleep(20);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите данные");
            Console.ForegroundColor = ConsoleColor.White;
            while (!finish)
            {
                try
                {
                    data = Console.ReadLine();
                    worker.Worker(data);
                    finish = true;
                }
                catch (Argument_shouldntBeNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
