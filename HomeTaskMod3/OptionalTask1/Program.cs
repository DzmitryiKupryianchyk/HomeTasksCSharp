using System.Collections.Generic;
using System.Text;

namespace OptionalTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string intro = "Реализовать в C# любой алгоритм нахождение наибольшего общего делителя для неопределенного количества входных чисел.";
            string answer;
            string argumentString;
            int argument;
            // Создаем делитель и присваеваем ему значение 1 т.к. на ноль делить нельзя
            int divide = 1;
            // Создаем переменную, которой позже присвоим значенме равное количеству введенных чисел
            int repeatDiv;
            // Создаем список, в который будем сохранять введенные с консоли числа
            List<int> arguments = new List<int>();
            // Создаем список, в который будем сохранять делители, делящие наши числа без остатка
            List<int> divider = new List<int>();
            foreach (char c in intro) 
            { 
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            do
            {
                // Вводим первое число и проверяем на правильность ввода. Если строка не конвертируется в int, повторяем ввод.
                Console.WriteLine("Введите целое число");
                argumentString = Console.ReadLine();
                if (Int32.TryParse(argumentString, out argument))
                {
                    Console.WriteLine("Число введено корректно.");   
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Введен неверный формат данных либо пустая строка. Попробуйте еще раз. Допустимы только целые числа");
                        argumentString = Console.ReadLine();
                    } while (!Int32.TryParse(argumentString, out argument));
                }
                // сохраняем введенное число в список и спрашиваем, нужно ли ввести еще одно число? Цикл будет повторятся, пока ответ "Y".
                arguments.Add(argument);
                Console.WriteLine("Добавить еще одно число? Нажмите Y если ДА, или любую другую клавишу если НЕТ");
                answer = Console.ReadLine();
            }
            while (answer == "Y" || answer == "y");
            Console.WriteLine($"Вы ввели числа: {string.Join(", ", arguments)}");
            Thread.Sleep(1000);
            //Ищем делители каждого из введенных чисел начиная с единицы (делитель divide = 1 создан выше)
            foreach (int i in arguments)
            {
                Console.Write($"Все делители числа {i}: ");
                do
                {
                    //Если делитель делит число без остатка, сохраняем его в коллекцию divider
                    if (i % divide == 0) 
                    { 
                        divider.Add(divide);
                        Console.Write($"{divide}, ");
                        Thread.Sleep(500);
                    }
                    // после проверки увеличиваем значение делителя на 1
                    divide++;
                    //цикл будет повторятся, пока делитель не станет равен проверяемому числу. Затем программа перейдет к проверке следующего числа в коллекции
                } while (divide <= i);
                Console.WriteLine();
                // Перед переходом к проверке следующего числа делителю снова нужно придать значение 1
                divide = 1;
            }
            //Этой переменной придаем значение, равное количеству введенных с консоли чисел, чтобы отобрать делители, встречающиеся в массиве столько раз, сколько цифр мы ввели( то есть все общие делители)
            repeatDiv = arguments.Count;
            // создаем новый список и отбираем туда все общие делители.
            // Я не понял толком как работают следующие 4 строчки, они загуглены на https://www.techiedelight.com/ru/find-duplicate-elements-in-a-list-in-csharp/
            List<int> commonDivider = divider.GroupBy(x => x)
                            .Where(g => g.Count() == repeatDiv)
                            .Select(x => x.Key)
                            .ToList();
            // Из коллекции общих делителей находим максимальное значение
            int maxCommonDivider = commonDivider.Max();
            Console.WriteLine($"Максимальный общий делитель чисел {string.Join(", ", arguments)} равен {maxCommonDivider}");
            Console.WriteLine("Работа программы завершена. Для выхода нажмите 'Enter'");
            Console.ReadKey();



        }
    }
}
