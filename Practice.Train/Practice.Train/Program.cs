using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Practice.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Carriage> carriages = new List<Carriage>();
            List<Passenger> passengers = new List<Passenger>();
            List<bool> allowanceFromEachCarriege = new List<bool>();
            FillInData(ref carriages, ref passengers);
            Train train = new Train(carriages);
            string attention = "Внимание!!! Наличие или отсутствие билетов у пассажиров задается генератором случайно с очень маленьким процентом значений false. Если безбилетники не сгенерировались, закройте и запустите консоль еще раз.";
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (char c in attention) 
            { 
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Thread.Sleep(3000);
            int count = 0;
            int i = 0;
            string choose;
            while (count < passengers.Count)
            {
                if ( i < carriages.Count) 
                {
                    for (int j = 0; j < 10; j++ )
                    {
                        carriages[i].AddPassenger(passengers[count]);
                        Console.WriteLine($" номер {i + 1}");
                        count++;
                    }
                    i++;
                }
            }
            Thread.Sleep(1500);

            Console.WriteLine("Пассажиры сели на места. Проверьте билеты, удалите безбилетников и в путь.");
            Thread.Sleep(1500);
        marker:
            Console.WriteLine();
            Console.WriteLine("Нажмите 1 чтобы посмотреть вместимость поезда.");
            Console.WriteLine("Нажмите 2 чтобы посмотреть количество вагонов.");
            Console.WriteLine("Нажмите 3 чтобы проверить билеты.");
            Console.WriteLine("Нажмите 4 чтобы удалить пассажира.");
            Console.WriteLine("Нажмите 5 чтобы увидеть список пассажиров в отдельном вагоне.");
            Console.WriteLine("Нажмите 6 чтобы посмотреть вместительность вагона.");
            Console.WriteLine("Нажмите 7 чтобы отправится в путь.");
            
            bool yep = false;
            do 
            {
                choose = Console.ReadLine();
                if (int.TryParse(choose, out count ) && count > 0 && count < 8) 
                {
                    yep = true;
                }
                else { Console.WriteLine("Введите корректный ответ"); }
            } while (!yep);

            switch (count) 
            {
                case 1:
                    train.GetCapacityOfTrain();
                    goto marker;
                case 2:
                    train.GetNumOfCarriages();
                    goto marker;
                case 3:
                    int ind = 1;  
                    Console.WriteLine();
                    carriages[0].AreAllPassengersAllowed(ind, out bool readyToRun);
                    allowanceFromEachCarriege.Add(readyToRun);
                    ind = 2;
                    carriages[1].AreAllPassengersAllowed(ind, out readyToRun);
                    allowanceFromEachCarriege.Add(readyToRun);
                    ind = 3;
                    carriages[2].AreAllPassengersAllowed(ind, out readyToRun);
                    allowanceFromEachCarriege.Add(readyToRun);
                    ind = 4;
                    carriages[3].AreAllPassengersAllowed(ind, out readyToRun);
                    allowanceFromEachCarriege.Add(readyToRun);
                    ind = 5;
                    carriages[4].AreAllPassengersAllowed(ind, out readyToRun);
                    allowanceFromEachCarriege.Add(readyToRun);
                    train.IsAllowedToMove(ref allowanceFromEachCarriege);
                    goto marker;
                case 4:
                    Console.WriteLine("Введите номер вагона, в котором находится пассажир к удалению.");
                    
                    string carS = "";
                    int car = 0;
                    bool correct = false;
                    do
                    {
                        carS = Console.ReadLine();
                        if (int.TryParse(carS, out car) && car > 0 && car < 6)
                        {
                            correct = true;
                        }
                        else 
                        {
                            Console.WriteLine("Введите корректный ответ.");
                        }
                    } while (!correct);
                    switch (car) 
                    {
                        case 1:
                            carriages[0].RemovePassenger();
                            break;
                        case 2:
                            carriages[1].RemovePassenger();
                            break;
                        case 3:
                            carriages[2].RemovePassenger();
                            break;
                        case 4:
                            carriages[3].RemovePassenger();
                            break;
                        case 5:
                            carriages[4].RemovePassenger();
                            break;
                    }
                    goto marker;
                case 5:
                    Console.WriteLine("Введите номер вагона для получения списка пассажиров.");
                     carS = "";
                     car = 0;
                     correct = false;
                    do
                    {
                        carS = Console.ReadLine();
                        if (int.TryParse(carS, out car) && car > 0 && car < 6)
                        {
                            correct = true;
                        }
                        else
                        {
                            Console.WriteLine("Введите корректный ответ.");
                        }
                    } while (!correct);
                    switch (car)
                    {
                        case 1:
                            carriages[0].GetListOfPassengers();
                            break;
                        case 2:
                            carriages[1].GetListOfPassengers();
                            break;
                        case 3:
                            carriages[2].GetListOfPassengers();
                            break;
                        case 4:
                            carriages[3].GetListOfPassengers();
                            break;
                        case 5:
                            carriages[4].GetListOfPassengers();
                            break;
                    }
                    goto marker;
                case 6:
                    Console.WriteLine("Введите номер вагона для получения информации о вместимости.");
                    carS = "";
                    car = 0;
                    correct = false;
                    do
                    {
                        carS = Console.ReadLine();
                        if (int.TryParse(carS, out car) && car > 0 && car < 6)
                        {
                            correct = true;
                        }
                        else
                        {
                            Console.WriteLine("Введите корректный ответ.");
                        }
                    } while (!correct);
                    switch (car)
                    {
                        case 1:
                            carriages[0].GetCapacityOfCarriage();
                            break;
                        case 2:
                            carriages[1].GetCapacityOfCarriage();
                            break;
                        case 3:
                            carriages[2].GetCapacityOfCarriage();
                            break;
                        case 4:
                            carriages[3].GetCapacityOfCarriage();
                            break;
                        case 5:
                            carriages[4].GetCapacityOfCarriage();
                            break;
                    }
                    goto marker;
                case 7:
                    train.Move(out bool succeeded);
                    if (succeeded) { break; }
                    else { goto marker; }       
            }
        }
        public static void FillInData(ref List<Carriage> carriages, ref List<Passenger> passengers) 
        {
            string name;
            string lastName;
            int ticket;
            string[] names = { "Jason", "Scarlett", "Alexander", "Zoey", "Harper", "Carter", "Emily", "Logan", "Jacob", "Michael", "Mason", "Lucas", "William", "Sophia", "Noah", "Olivia", "Liam", "Hamma", "Aiden", "Audrey" };
            string[] lastNames = { "Taylor", "Bailey", "Jordan", "Cameron", "Casey", "Avery", "Morgan", "Riley", "Parker", "Dakota", "Reese", "Shannon", "Scout", "Sky", "Sage", "Sawyer", "Finley", "Hayden", "Peyton", "Quinn" };
            bool hasTicket;
            double truePer = 0.9;
            
            for (int i = 1; i <= 30; i++) 
            {
                Random rand = new Random();
                name = names[rand.Next(0, names.Length - 1)];
                lastName = lastNames[rand.Next(0, names.Length - 1)];
                if (rand.NextDouble() < truePer)
                {
                    hasTicket = true;
                }
                else
                {
                    hasTicket = false;
                }
                
                passengers.Add(new Passenger(name, lastName, hasTicket));
            }
            for (int i = 0; i < 5; i++) 
            {
                carriages.Add(new Carriage());
            }
        }
    }
}
