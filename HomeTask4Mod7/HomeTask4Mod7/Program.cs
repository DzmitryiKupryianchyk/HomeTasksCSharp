using System.Text;

namespace HomeTask4Mod7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<string> fillQueue = new List<string>();
            string intro = "Создать класс Queue";
            string argument;
            string answer;
            bool isTrue = false;
            int choise;

            foreach (char c in intro)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.WriteLine("Введите первый элемент очереди.");

            do
            {
                argument = Console.ReadLine();
                if (!String.IsNullOrEmpty(argument))
                {
                    isTrue = true;
                    fillQueue.Add(argument);
                }
                else Console.WriteLine("Пустая строка. введите данные.");
                tryAgain:
                Console.WriteLine("Добавит еще одно значение? Y/N");
                answer = Console.ReadLine();
                if (answer == "Y" || answer == "y") { isTrue = false; Console.WriteLine("Введите значение"); }
                else if (answer == "N" || answer == "n") { Console.WriteLine("Следующий этап"); isTrue = true; }
                else { Console.WriteLine("Дайте корректный ответ"); goto tryAgain; }
            } while (!isTrue);

            ClassQueue que = new ClassQueue(fillQueue, argument);

            Console.WriteLine("Операции с очередью.");
            Console.WriteLine("Нажмите 1, чтобы посмотреть содержимое очереди.");
            Console.WriteLine("Нажмите 2, чтобы посмотреть первый элемент очереди.");
            Console.WriteLine("Нажмите 3, чтобы посмотреть убрать первый элемент очереди.");
            Console.WriteLine("Нажмите 4, чтобы очистить очередь.");
            Console.WriteLine("Нажмите 5, чтобы добавить элемент в очередь.");
            do
            {
            again:
                choise = int.Parse(Console.ReadLine());
                if (choise == 1 || choise == 2 || choise == 3 || choise == 4 || choise == 5)
                {
                    switch (choise)
                    {
                        case 1:
                            que.ToSeeAllQueue();
                            break;
                        case 2:
                            que.PeekLastItem();
                            break;
                        case 3:
                            que.DequeueOutFromQueue();
                            break;
                        case 4:
                            que.EraseAllElements();
                            break;
                        case 5:
                            do
                            {
                                isTrue = false;
                                Console.WriteLine("Введите данные");
                                argument = Console.ReadLine();
                                if (!String.IsNullOrEmpty(argument))
                                {
                                    Console.WriteLine("Принято");
                                    isTrue = true;
                                    que.EnqueueElement(argument);
                                }
                                else Console.WriteLine("Пустая строка. введите данные.");
                            } while (!isTrue);
                            
                            break;
                    }
                tryaskAgain:
                    Console.WriteLine("Выполнить еще одну операцию? Y/N");
                    answer = Console.ReadLine();
                    if (answer == "Y" || answer == "y") { isTrue = true; Console.WriteLine("Выберите действие"); }
                    else if (answer == "N" || answer == "n") { Console.WriteLine("принято"); isTrue = false; }
                    else { Console.WriteLine("Дайте корректный ответ"); goto tryaskAgain; }
                }
                else { Console.WriteLine("Нет такого варианта. попробуйте еще"); goto again; }
            } while (isTrue);
            Console.WriteLine("Работа завершена");
            Console.ReadKey();
        }
    }
}
