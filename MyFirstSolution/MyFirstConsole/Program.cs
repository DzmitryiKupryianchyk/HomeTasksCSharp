using System.Text;

namespace MyFirstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string task1 = "Задание номер 1. В методе Main консольного проекта создать переменную типа int со значением 10. Вывести ее на консоль.Сделать так, чтобы программа завершала работу только тогда, когда вы введете с клавиатуры какой-либо символ и нажмете Enter.";
            foreach (char l in task1) { Console.Write(l); Thread.Sleep(50); }
            Console.WriteLine();
            int value = 10;
            string finish = "Для завершения работы консоли нажмите 'пробел', затем нажмите клавишу 'Enter'.";
            string exit;
            Console.WriteLine(" Значение переменной value = " + value);
            Thread.Sleep(2000);
            foreach(char i in finish) 
            {
                Console.Write(i);
                Thread.Sleep(50);           
            }
            Console.WriteLine();
            while (Console.ReadKey().Key != ConsoleKey.Spacebar)
            {
                Console.ReadKey();
            }
        }
    }
}
