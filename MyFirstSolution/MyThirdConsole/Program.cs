using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyThirdConsole
{
    internal class Program
    {
        public class Arg 
        {
            public string inArg;
            public int argument;
            public string answer;
            public int sum;
            public float argumentQuantity;
            public float average;
            public List<int> argumentList = new List<int>();
            public bool success = false;
            public void Count()
            {
                do
                {
                    Console.WriteLine("Введите целое число");
                    inArg = Console.ReadLine();
                    if (Int32.TryParse(inArg, out argument) ) 
                    {
                        success = true;
                        Console.WriteLine("Число введено корректно.");
                        Thread.Sleep(1500);
                    }
                    else 
                    {
                        do
                        {
                            Console.WriteLine("Введен неверный формат данных либо пустая строка. Попробуйте еще раз. Допустимы только целые числа");
                            inArg = Console.ReadLine();
                        } while (!Int32.TryParse(inArg, out argument));  
                    } 
                    argumentList.Add(argument);
                    Console.WriteLine("Добавить еще одно число? Нажмите Y если ДА, или любую другую клавишу если НЕТ");
                    answer = Console.ReadLine();
                }
                while (answer == "Y" || answer == "y");
                Console.WriteLine("Числа введены.");
            }
            public void Math() 
            {
                sum = argumentList.Sum();
                argumentQuantity = argumentList.Count;
                average = sum / argumentQuantity;
            }
            public void Conclusion() 
            {
                Console.WriteLine($"Вы ввели {argumentQuantity} чисел");
                foreach (int i in argumentList)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Среднее значение ваших чисел = " + average);
                Console.ReadKey();
            }   
        }
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string task4 = "Задание номер 4. Ввести с консоли несколько чисел и найти их среднее арифметическое.";
            foreach (char l in task4) { Console.Write(l); Thread.Sleep(50); }
            Console.WriteLine();
            Thread.Sleep(2000);
            var first = new Arg();
            first.Count();
            first.Math();
            first.Conclusion();   
        }
    }
}
