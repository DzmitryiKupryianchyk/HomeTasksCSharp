using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Train
{
    internal class Carriage : AbstractCarriage
    {
        public List<Passenger> passengers = new List<Passenger>();
        public int seats = 10;
        public Carriage() 
        { 
        }
        public override void AddPassenger(Passenger passenger)
        {
            if (passengers.Count < seats)
            {
                passengers.Add(passenger);
                Console.Write($"{passenger.name} {passenger.lastName} добавлен в вагон ");
            }
            else Console.WriteLine("Вагон полон. Добавьте пассажира в другой вагон.");
        }

        public override void AreAllPassengersAllowed(int ind, out bool readyToRun)
        {
            readyToRun = true;
            
            foreach (var passenger in passengers) 
            {
                if (passenger.hasTicket == false) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Пассажир номер {passengers.IndexOf(passenger) + 1} вагона номер {ind} : Имя - {passenger.name} {passenger.lastName} не имеет билета.");
                    Console.ForegroundColor = ConsoleColor.White;
                    readyToRun = false;
                } 
                else { Console.WriteLine($"Пассажир номер {passengers.IndexOf(passenger) + 1} вагона номер {ind} : Имя - {passenger.name} {passenger.lastName} наличие билета {passenger.hasTicket} ."); }
            }
            Thread.Sleep(1500);
            Console.WriteLine();

        }

        public override int GetCapacityOfCarriage()
        {
            Console.WriteLine($"Вместительность вагона - {seats} мест");
            Thread.Sleep(1500);
            return seats;
        }

        public override void GetListOfPassengers()
        {
            foreach (Passenger passenger in passengers) 
            {
                Console.WriteLine($"Пассажир номер {passengers.IndexOf(passenger) + 1}: Имя - {passenger.name} {passenger.lastName} наличие билета - {passenger.hasTicket}");
            }
            Thread.Sleep(1500);
            Console.WriteLine();
        }

        public override void RemovePassenger()
        {
            string remS;
            int remove;
            bool correct = false;

            foreach (Passenger passenger in passengers)
            {
                if (passenger.hasTicket == false) Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Пассажир номер {passengers.IndexOf(passenger) + 1}: Имя - {passenger.name}  {passenger.lastName} наличие билета - {passenger.hasTicket}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            Console.WriteLine("Введите номер пассажира, которого нужно удалить.");
            do 
            {
                remS = Console.ReadLine();
                if (int.TryParse(remS, out remove) && remove <= passengers.Count) 
                {
                    correct = true;
                    Console.Write($"Пассажир номер {remove}: ");
                    --remove;
                    Console.WriteLine($"Имя - {passengers[remove].name} {passengers[remove].lastName} удален из поезда.");
                    ++remove;
                    passengers.RemoveAt(--remove);
                }
                else Console.WriteLine("Введите номер пассажира корректно");
            }while (!correct);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("После удаления всех безбилетников проверьте билеты еще раз, чтобы получить подтверждение о готовности отправляться.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1500);
        }
    }
}
