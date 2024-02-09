using System.Text;

namespace WASDMoveSomething
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string intro = "Ввести с клавиатуры символ. Определить, необходимо ли нам переместить фигуру вверх, вниз, вправо или влево в зависимости от введенного символва (W,A,S,D). Вывести результат решения на экран. В случае отсутствия необходимости перемещения вывести соответствующее сообщение.";
            string fromConsole;
            string answer;
            foreach (char c in intro) 
            { 
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("W-вверх, A-влево, S-вниз, D-вправо, любая клавиша-не двигать.");
            Thread.Sleep(500);
            GoToMark:
            Console.WriteLine("Введите символ");
            fromConsole = Console.ReadLine();
            switch (fromConsole) 
            {
                case "w":
                    Console.WriteLine("Перемещаем фигуру вверх");
                    Thread.Sleep(500);
                    Console.WriteLine("повторить?Y/N");
                    do
                    {
                        answer = Console.ReadLine();
                        if (answer == "y" || answer == "Y" || answer == "у" || answer == "У")
                        {
                            goto GoToMark;
                        }
                        else if (answer == "n" || answer == "N" || answer == "н" || answer == "Н")
                        {
                            Console.WriteLine("Завершение работы программы.");
                            //return;
                        }
                        else Console.WriteLine("Пожалуйста, введите корректный ответ.");
                    }
                    while (answer != "y" && answer != "Y" && answer != "у" && answer != "У" && answer != "n" && answer != "N" && answer != "н" && answer != "Н");
                    break;
                case "a":
                    Console.WriteLine("Перемещаем фигуру влево");
                    Thread.Sleep(500);
                    Console.WriteLine("повторить?Y/N");
                    do
                    {
                        answer = Console.ReadLine();
                        if (answer == "y" || answer == "Y" || answer == "у" || answer == "У")
                        {
                            goto GoToMark;
                        }
                        else if (answer == "n" || answer == "N" || answer == "н" || answer == "Н")
                        {
                            Console.WriteLine("Завершение работы программы.");
                            //return;
                        }
                        else Console.WriteLine("Пожалуйста, введите корректный ответ.");
                    }
                    while (answer != "y" && answer != "Y" && answer != "у" && answer != "У" && answer != "n" && answer != "N" && answer != "н" && answer != "Н");
                    break;
                case "s":
                    Console.WriteLine("Перемещаем фигуру вниз");
                    Thread.Sleep(500);
                    Console.WriteLine("повторить?Y/N");
                    do
                    {
                        answer = Console.ReadLine();
                        if (answer == "y" || answer == "Y" || answer != "у" || answer != "У")
                        {
                            goto GoToMark;
                        }
                        else if (answer == "n" || answer == "N" || answer == "н" || answer == "Н")
                        {
                            Console.WriteLine("Завершение работы программы.");
                            //return;
                        }
                        else Console.WriteLine("Пожалуйста, введите корректный ответ.");
                    }
                    while (answer != "y" && answer != "Y" && answer != "у" && answer != "У" && answer != "n" && answer != "N" && answer != "н" && answer != "Н");
                    break;
                case "d":
                    Console.WriteLine("Перемещаем фигуру вправо");
                    Thread.Sleep(500);
                    Console.WriteLine("повторить?Y/N");
                    do
                    {
                        answer = Console.ReadLine();
                        if (answer == "y" || answer == "Y" || answer == "у" || answer == "У")
                        {
                            goto GoToMark;
                        }
                        else if (answer == "n" || answer == "N" || answer == "н" || answer == "Н")
                        {
                            Console.WriteLine("Завершение работы программы.");
                            //return;
                        }
                        else Console.WriteLine("Пожалуйста, введите корректный ответ.");
                    }
                    while (answer != "y" && answer != "Y" && answer != "у" && answer != "У" && answer != "n" && answer != "N" && answer != "н" && answer != "Н");
                    break;
                default:
                    Console.WriteLine("фигура остается на месте");
                    Thread.Sleep(500);
                    Console.WriteLine("повторить?Y/N");
                    do
                    {
                        answer = Console.ReadLine();
                        if (answer == "y" || answer == "Y" || answer == "у" || answer == "У")
                        {
                            goto GoToMark;
                        }
                        else if (answer == "n" || answer == "N" || answer == "н" || answer == "Н")
                        {
                            Console.WriteLine("Завершение работы программы.");
                            //return;
                        }
                        else Console.WriteLine("Пожалуйста, введите корректный ответ.");
                    }
                    while (answer != "y" && answer != "Y" && answer != "у" && answer != "У" && answer != "n" && answer != "N" && answer != "н" && answer != "Н");
                    break;
            }

        }
    }
}
