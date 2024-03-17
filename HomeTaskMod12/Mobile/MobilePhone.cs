using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    internal class MobilePhone<T> where T: MobileNetwork
    {
        bool isConnected = false;
        T currentConnection;
        public string Model { get; set; }
        public string SimCard { get; set; }
        public bool roamingSwitchedOn = true;
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
            else if (net is LocalNetworks && isConnected)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Подключение отклонено!!!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Телефон уже подключен к сети ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{currentConnection}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (net is ForeignNetworks) 
            {
                if (!isConnected) 
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Отказано. Сим-карта не подключена к местной сети.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (currentConnection.roaming)
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
                    Console.WriteLine($"Телефон {Model} подключен к иностранной сети {net.Name}. Локация - {net.Country}");
                    isConnected = true;
                    Thread.Sleep(1000);
                    net.ShowServices();
                }
                else if (!currentConnection.roaming) 
                {
                    Console.Write("Идет подключение");
                    Thread.Sleep(1000);
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("_");
                        Thread.Sleep(1000);
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Подключение отклонено!!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" Сим карта {SimCard} не может подключиться к иностранной сети {net.Name}. Необходимо подключить роуминг.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (net is LocalNetworks && !SimCard.Equals(net.Name.ToString()))
            {
                Console.Write("Идет подключение");
                Thread.Sleep(1000);
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("_");
                    Thread.Sleep(1000);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Подключение отклонено!!!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" Сим карта {SimCard} не может подключиться к сети {net.Name}. Подключитесь к сети своего оператора.");
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
                currentConnection = network;
                Thread.Sleep(1000);
                net.ShowServices();
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
                currentConnection = null;
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
        public void CheckRoaming() 
        {
            if (!isConnected) 
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Сим-карта не подключена. Роуминг недоступен.");
                Console.ForegroundColor = ConsoleColor.White;
            } else net.IsRoaming();
        }
        public void SwitchRoaming() 
        {
            if (!isConnected)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Невозможно подключить роуминг!!!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" Телефон не подключен к сети.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep( 1000 );
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Внимание!!! Прежде чем подключаться к сети иностранных операторов необходимо: Вставить сим-карту => подключится к сети вашего оператора => подключить роуминг => подключиться к сети иностранного оператора. ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else 
            {
                net.Roaming();
            }
        }
    }
}
