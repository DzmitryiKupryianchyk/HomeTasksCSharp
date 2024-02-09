using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Text;

namespace MySecondConsole
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string task2 = "Задание номер 2. Создать переменные e = 1.414213562373095048 и pi = 3.141592653 и вывести на консоль без потери точности.";
            foreach (char l in task2) {  Console.Write(l); Thread.Sleep(50); }
            Console.WriteLine();
            decimal pi = 3.141592653M;
            decimal e = 1.414213562373095048M;
            Console.WriteLine("значение числа pi = " + pi);
            Thread.Sleep(1000);
            Console.WriteLine("константа Пифагора е = " + e);
            Thread.Sleep(1000);
            string specification = "Для сохранения точности переменные были инициализированы как тип decimal: decimal pi = 3.141592653M и decimal e = 1.414213562373095048M";
            foreach(char l in specification) 
            {
                Console.Write(l);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.WriteLine("Задание номер 2 завершено");

            string task3 = "Задание номер 3. Создать переменную ‘a’ типа int со значением 3. Создать переменную ‘b’ типа byte и присвоить ей значение переменной ‘a’.";
            foreach (char l in task3) { Console.Write(l); Thread.Sleep(50); }
            Console.WriteLine();
            int a = 3;
            byte b = (byte)a;
            Console.WriteLine($"int a = {a}; byte b = (byte)a;  b = {b} ");
            Thread.Sleep(1000);
            Console.WriteLine("Задание номер 3 завершено");
            Console.ReadKey();
        }
    }
}
