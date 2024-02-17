using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Task2Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool isCorrect = false;
            int[,] array1 =  new int[3,3];
            int[,] array2 = new int[3, 3];
            int[,] result = new int[3, 3];
            string intro = "Сложить 2 двумерных массива, результат вернуть в виде нового третьего двумерного массива.";
            foreach (char c in intro) 
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("Введите 6 целочисленных значений. Первые 3 числа будут элементами первого измерения первого массива, вторая тройка чисел будет элементами второго измерения первого массива. В качестиве разделителя используйте пробел.");

            while (!isCorrect) 
            {
                int iterCount = 0;
                int arrInd = 0;
                string[] valuesOfArray1 = Regex.Split(Console.ReadLine(), " ");
                foreach (string value in valuesOfArray1) 
                {
                    if (Int32.TryParse(value, out int num))
                    {
                        isCorrect = true;
                    }
                    else Console.WriteLine($"Ошибка ввода данных. Недопустимое значение {value}");

                }
                for (int i = 0; i < 3; i++)
                {
                    array1[arrInd, i] = Int32.Parse(valuesOfArray1[iterCount]);
                    Console.WriteLine($"Элементу [{arrInd},{i}] массива {nameof(array1)} присвоено значение {valuesOfArray1[iterCount]}.");
                    iterCount++;
                }
                arrInd++;
                for (int j = 0; j < 3; j++)
                {
                    array1[arrInd, j] = Int32.Parse(valuesOfArray1[iterCount]);
                    Console.WriteLine($"Элементу [{arrInd},{j}] массива {nameof(array1)} присвоено значение {valuesOfArray1[iterCount]}.");
                    iterCount++;
                }
            }
            isCorrect = false;
            Console.WriteLine("Введите 6 целочисленных значений второго массива. Первые 3 числа будут элементами первого измерения второго массива, вторая тройка чисел будет элементами второго измерения второго массива. В качестиве разделителя используйте пробел.");
            while (!isCorrect)
            {
                int iterCount = 0;
                int arrInd = 0;
                string[] valuesOfArray2 = Regex.Split(Console.ReadLine(), " ");
                foreach (string value in valuesOfArray2)
                {
                    if (Int32.TryParse(value, out int num))
                    {  
                        isCorrect = true;
                    }
                    else Console.WriteLine($"Ошибка ввода данных. Недопустимое значение {value}");
                }
                for (int i = 0; i < 3; i++)
                {
                    array2[arrInd, i] = Int32.Parse(valuesOfArray2[iterCount]);
                    Console.WriteLine($"Элементу [{arrInd},{i}] массива {nameof(array2)} присвоено значение {valuesOfArray2[iterCount]}.");
                    iterCount++;
                }
                arrInd++;
                for (int j = 0; j < 3; j++)
                {
                    array2[arrInd, j] = Int32.Parse(valuesOfArray2[iterCount]);
                    Console.WriteLine($"Элементу [{arrInd},{j}] массива {nameof(array2)} присвоено значение {valuesOfArray2[iterCount]}.");
                    iterCount++;
                }
            }
            Console.WriteLine("Теперь математика.");

            Math(array1, array2, ref result);

            Thread.Sleep(1000);
            Console.WriteLine($"{array1[0, 0]} + {array2[0, 0]} = {result[0, 0]}");
            Thread.Sleep(100);
            Console.WriteLine($"{array1[0, 1]} + {array2[0, 1]} = {result[0, 1]}");
            Thread.Sleep(100);
            Console.WriteLine($"{array1[0, 2]} + {array2[0, 2]} = {result[0, 2]}");
            Thread.Sleep(100);
            Console.WriteLine($"{array1[1, 0]} + {array2[1, 0]} = {result[1, 0]}");
            Thread.Sleep(100);
            Console.WriteLine($"{array1[1, 1]} + {array2[1, 1]} = {result[1, 1]}");
            Thread.Sleep(100);
            Console.WriteLine($"{array1[1, 2]} + {array2[1, 2]} = {result[1, 2]}");
            Thread.Sleep(1000);
            for (int i = 0;i < 2;i++) 
            {
                for (int j = 0;j < 3;j++) 
                {
                    Console.WriteLine($"Элементу [{i},{j}] массива {nameof(result)} присвоено значение {result[i, j]}.");
                }
            }
            Console.ReadKey();
        }
        public static void Math(int[,] array1, int[,] array2, ref int[,] result) 
        {
            result[0, 0] = array1[0, 0] + array2[0, 0];
            result[0, 1] = array1[0, 1] + array2[0, 1];
            result[0, 2] = array1[0, 2] + array2[0, 2];
            result[1, 0] = array1[1, 0] + array2[1, 0];
            result[1, 1] = array1[1, 1] + array2[1, 1];
            result[1, 2] = array1[1, 2] + array2[1, 2];
        }
    }
}
