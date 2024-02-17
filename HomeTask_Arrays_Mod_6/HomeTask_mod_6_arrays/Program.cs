using System.Text;

namespace HomeTask_mod_6_arrays
{
    internal class Program
    {
        public class Array
        {

            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
                string[] data;
                string intro = "Массивы и данные";
                string answer;
                int iterCount = 0;
                string arrLenghtS;
                int arrayLenght;
                string argument = "0";

                foreach (char c in intro)
                {
                    Console.Write(c);
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                Console.WriteLine("Задайте размер вашего массива");
                do
                {
                    arrLenghtS = Console.ReadLine();
                    if (Int32.TryParse(arrLenghtS, out arrayLenght))
                    {
                        Console.WriteLine($"Размер массива {nameof(data)} - {arrayLenght} элементов.");
                    }
                    else Console.WriteLine("");
                }
                while (!Int32.TryParse(arrLenghtS, out arrayLenght));
                data = new string[arrayLenght];

                bool positive;
                do
                {
                    Console.WriteLine("Ввести строку? Y/N");
                    answer = Console.ReadLine();
                    if (answer == "y" || answer == "Y" || answer == "у" || answer == "У")
                    {
                        positive = true;
                        Console.WriteLine("Введите строку");
                        argument = Console.ReadLine();
                        if (!string.IsNullOrEmpty(argument))
                        {
                            Console.WriteLine("Строка принята.");
                            Thread.Sleep(1500);
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("Введен неверный формат данных либо пустая строка. Попробуйте еще раз. ");
                                argument = Console.ReadLine();
                            } while (string.IsNullOrEmpty(argument));
                        }
                        ArrayAdd(ref data, argument, out bool isSaved);
                        if (isSaved) { iterCount++; }

                    }
                    else if (answer == "n" || answer == "N")
                    {
                        Console.WriteLine("Принято.");
                        Thread.Sleep(1000);
                        goto flag2;
                    }
                    else
                    {
                        positive = false;
                        Console.WriteLine("Пожалуйста, введите корректный ответ.");
                    }

                } while ((answer != "y" || answer != "Y" || answer != "у" || answer != "У") & iterCount <= arrayLenght);

                string[] secondArr = clonedData(argument, data);

                do
                {
                askAgain:
                    Console.WriteLine("Ввести еще одну строку? Нажмите Y/N");
                    answer = Console.ReadLine();
                    if (answer == "y" || answer == "Y" || answer == "у" || answer == "У")
                    {
                        do
                        {
                            Console.WriteLine("Введите данные.");
                            argument = Console.ReadLine();
                        } while (string.IsNullOrEmpty(argument));

                    }
                    else if (answer == "n" || answer == "N")
                    {
                        goto flag3;
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста, ответьте корректно.");
                        goto askAgain;
                    }

                    AddToClone(argument, secondArr, out bool isSaved);
                    if (!isSaved)
                    {
                    again:
                        Console.WriteLine("Расшитить второй массив? Y/N");

                        answer = Console.ReadLine();
                        if (answer == "y" || answer == "Y" || answer == "у" || answer == "У")
                        {
                            WidenSecondArr(ref secondArr);
                            AddToClone(argument, secondArr, out isSaved);
                        }
                        else if (answer == "n" || answer == "N")
                        {
                            Console.WriteLine("Массив не расширен, последний элемент не был сохранен.");
                            goto flag3;
                        }
                        else
                        {
                            Console.WriteLine("Пожалуйста, введите корректный ответ.");
                            goto again;
                        }
                    }
                } while (answer != "y" || answer != "Y" || answer != "у" || answer != "У");
            flag3:
                int dataCount = 1;
                foreach (string s in data)
                {
                    Console.WriteLine($"Элемент массива {nameof(data)} номер {dataCount++} = {s}");
                }
                int secondArrCount = 1;
                foreach (string s in secondArr)
                {
                    Console.WriteLine($"Элемент массива {nameof(secondArr)} номер {secondArrCount++} = {s}");
                }
                Console.ReadKey();
                return;
            flag2:
                int dataCount1 = 1;
                foreach (string s in data)
                {
                    Console.WriteLine($"Элемент массива {nameof(data)} номер {dataCount1++} = {s}");
                }

                Console.ReadKey();

            }
            public static void ArrayAdd(ref string[] data, string argument, out bool isSaved)
            {
                isSaved = false;
                for (int i = 0; i < data.Length; i++)
                {
                    if (i == data.Length - 1 && data[i] != null)
                    {
                        Console.WriteLine($"В массиве {nameof(data)} нет свободных элементов. Требуется создание нового массива.");
                        Console.WriteLine("Данные первого массива будут сохранены в новый массив. Длина второго массива должна быть больше, чем первого.");
                        Thread.Sleep(1000);
                        isSaved = true;
                    }

                    else if (argument.Equals(data[i], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Массив уже содержит данное значение. Введите другое значение.");
                        break;
                    }
                    else if (data[i] == null)
                    {
                        Console.WriteLine($"В массиве {nameof(data)} элемент {i + 1} пуст.");
                        Thread.Sleep(1000);
                        data[i] = argument;
                        Console.WriteLine($"Элементу {i + 1} массива {nameof(data)} присвоена строка {argument}");
                        isSaved = true;
                        break;
                    }

                }

            }
            public static string[] clonedData(string argument, string[] data)
            {
                string arrSizeStr;
                int arrSize = 0;
                bool isTrue = false;
                Console.WriteLine("Введите желаемую длину нового массива.");
                while (!isTrue)
                {
                    arrSizeStr = Console.ReadLine();
                    if (Int32.TryParse(arrSizeStr, out arrSize) && data.Length < arrSize)
                    {
                        isTrue = true;
                    }
                    else Console.WriteLine($"Введите значение, большее {data.Length} ");
                }
                string[] clonedData = (string[])data.Clone();
                System.Array.Resize(ref clonedData, arrSize);
                Console.WriteLine($"Создан новый массив с размером {arrSize} элементов и сохраненными элементами предыдущего массива.");
                for (int i = 0; i < clonedData.Length; i++)
                {
                    if (argument.Equals(clonedData[i], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Массив уже содержит данное значение. Введите другое значение.");

                        break;
                    }
                    else if (clonedData[i] == null)
                    {
                        Console.WriteLine($"В новом массиве элемент {i + 1} пуст.");
                        Thread.Sleep(1000);
                        clonedData[i] = argument;
                        Console.WriteLine($"Элементу {i + 1} массива присвоена строка {argument}");
                        break;
                    }
                }
                return clonedData;
            }
            public static void AddToClone(string argument, string[] secondArr, out bool isSaved)
            {
                isSaved = true;
                for (int i = 0; i < secondArr.Length; i++)
                {
                    if (i == secondArr.Length - 1 && secondArr[i] != null)
                    {
                        Console.WriteLine($"В массиве {nameof(secondArr)} нет свободных элементов. Требуется расширение массива.");
                        isSaved = false;
                    }
                    if (argument.Equals(secondArr[i], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Массив уже содержит данное значение. Введите другое значение.");

                        break;
                    }
                    else if (secondArr[i] == null)
                    {
                        Console.WriteLine($"В массиве {nameof(secondArr)} элемент {i + 1} пуст.");
                        Thread.Sleep(1000);
                        secondArr[i] = argument;
                        Console.WriteLine($"Элементу {i + 1} массива {nameof(secondArr)} присвоена строка {argument}");
                        break;
                    }

                }
                Console.WriteLine();
            }
            public static void WidenSecondArr(ref string[] secondArr)
            {
                string arrSizeStr;
                int arrSize = 0;
                bool isTrue = false;
                Console.WriteLine("На какое количество элементов требуется расширить массив?");
                while (!isTrue)
                {
                    arrSizeStr = Console.ReadLine();
                    if (Int32.TryParse(arrSizeStr, out arrSize))
                    {
                        isTrue = true;
                    }
                }
                System.Array.Resize(ref secondArr, secondArr.Length + arrSize);

                Console.WriteLine($"Массив {nameof(secondArr)} расширен на {arrSize} элементов.");
            }
        }
    }
}

