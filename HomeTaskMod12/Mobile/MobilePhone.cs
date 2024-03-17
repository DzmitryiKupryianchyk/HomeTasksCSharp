using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    internal class MobilePhone<T> where T : MobileNetwork
    {
        bool isConnected = false;
        private string currentConnection;
        public string Model { get; set; }
        public string SimCard { get; set; }
        T net;
        public void Connect(T network) 
        {
            net = network;
            if (String.IsNullOrEmpty(SimCard))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Подключение невозможно. Нет сим-карты!!!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (isConnected)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Подключение отклонено!!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Телефон уже подключен к сети ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{currentConnection}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (!SimCard.Equals(net.Name.ToString())) 
            {
                Console.Write("Идет подключение");
                Thread.Sleep(1000);
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("_");
                    Thread.Sleep(1000);
                }
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Подключение отклонено!!!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" Сим карта {SimCard} не может подключиться к сети {net.Name}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {

                Console.Write("Идет подключение");
                Thread.Sleep(1000);
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("_");
                    Thread.Sleep(1000);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Успешно:)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Телефон {Model} подключен к сети {net.Name}. Локация - {net.Country}");
                isConnected = true;
                currentConnection = net.Name.ToString();
                Thread.Sleep(1000);
                net.ShowServices();
                System.Environment.Exit(0);
            }
        }
        public void Disconnect() 
        {
            if (isConnected)
            {
                Console.Write("Телефон отключен от сети ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(currentConnection);
                Console.ForegroundColor = ConsoleColor.White;
                isConnected = false;
                currentConnection = "";
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Запрос отклонен!!!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" Телефон не подключен к сети.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
