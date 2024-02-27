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
            int[,] array1 = new int[10, 10];
            int[,] array2 = new int[10, 10];
            int[,] result = new int[10, 10];
            string intro = "Сложить 2 двумерных массива, результат вернуть в виде нового третьего двумерного массива.";
            foreach (char c in intro)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("Введите несколько значений первого массива. Массив может содержать максимум 20 чисел. Первая половина будет элементами первого измерения первого массива, вторая половина чисел будет элементами второго измерения первого массива. В качестиве разделителя используйте пробел.");

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
                int halfofArray = valuesOfArray1.Length / 2;

                for (int i = 0; i < halfofArray; i++)
                {
                    array1[arrInd, i] = Int32.Parse(valuesOfArray1[iterCount]);
                    Console.WriteLine($"Элементу [{arrInd},{i}] массива {nameof(array1)} присвоено значение {valuesOfArray1[iterCount]}.");
                    iterCount++;
                }
                arrInd++;
                if (valuesOfArray1.Length % 2 != 0)
                {
                    for (int j = 0; j <= halfofArray; j++)
                    {
                        array1[arrInd, j] = Int32.Parse(valuesOfArray1[iterCount]);
                        Console.WriteLine($"Элементу [{arrInd},{j}] массива {nameof(array1)} присвоено значение {valuesOfArray1[iterCount]}.");
                        iterCount++;
                    }
                }
                else
                {
                    for (int j = 0; j < halfofArray; j++)
                    {
                        array1[arrInd, j] = Int32.Parse(valuesOfArray1[iterCount]);
                        Console.WriteLine($"Элементу [{arrInd},{j}] массива {nameof(array1)} присвоено значение {valuesOfArray1[iterCount]}.");
                        iterCount++;
                    }
                }
            }
            isCorrect = false;
            Console.WriteLine("Введите несколько значений второго массива. Массив может содержать максимум 20 чисел. Первая половина будет элементами второго измерения первого массива, вторая половина чисел будет элементами второго измерения второго массива. В качестиве разделителя используйте пробел.");
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
                int halfofArray = valuesOfArray2.Length / 2;
                for (int i = 0; i < halfofArray; i++)
                {
                    array2[arrInd, i] = Int32.Parse(valuesOfArray2[iterCount]);
                    Console.WriteLine($"Элементу [{arrInd},{i}] массива {nameof(array2)} присвоено значение {valuesOfArray2[iterCount]}.");
                    iterCount++;
                }
                arrInd++;
                if (valuesOfArray2.Length % 2 != 0)
                {
                    for (int j = 0; j <= halfofArray; j++)
                    {
                        array2[arrInd, j] = Int32.Parse(valuesOfArray2[iterCount]);
                        Console.WriteLine($"Элементу [{arrInd},{j}] массива {nameof(array2)} присвоено значение {valuesOfArray2[iterCount]}.");
                        iterCount++;
                    }
                }
                else
                {
                    for (int j = 0; j < halfofArray; j++)
                    {
                        array2[arrInd, j] = Int32.Parse(valuesOfArray2[iterCount]);
                        Console.WriteLine($"Элементу [{arrInd},{j}] массива {nameof(array2)} присвоено значение {valuesOfArray2[iterCount]}.");
                        iterCount++;
                    }
                }
            }
            Console.WriteLine("Теперь математика.");

            Math(array1, array2, ref result);

            Console.ReadKey();
        }
        public static void Math(int[,] array1, int[,] array2, ref int[,] result)
        {
            Console.WriteLine("Первый массив:");
            for (int i = 0; i < array1.Rank; i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    if (array1[i, j] != 0)
                    {
                        Console.Write($"{array1[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Второй массив:");
            for (int i = 0; i < array2.Rank; i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    if (array2[i, j] != 0)
                    {
                        Console.Write($"{array2[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Результат");
            for (int i = 0; i < array1.Rank; i++)
            {

                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    if (array1[i, j] != 0 || array2[i, j] != 0)
                    {
                        Console.Write($"{result[i, j] = array1[i, j] + array2[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
