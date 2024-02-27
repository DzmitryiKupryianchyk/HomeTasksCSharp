using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Train
{
    internal class Train : AbstractTrain
    {
        public List<Carriage> carriages = new List<Carriage>();
        bool allowedToMove = false;
        bool ticketsChecked = false;
        public Train(List<Carriage> carriages) : base(carriages) 
        {
            this.carriages = carriages;
        }
        public override void AddCarriage(Carriage carriage)
        {
            carriages.Add(carriage);
            Console.WriteLine("В поезд добавлен 1 вагон.");
            
        }
        public override void RemoveCarriage()
        {
            string remS;
            int rem;
            bool correct = false;
            Console.WriteLine("Введите номер вагона, который нужно удалить.");
            Console.WriteLine($"В поезде {carriages.Count} вагонов. Введите номер вагона от 1 до {carriages.Count}");
            do
            {
                remS = Console.ReadLine();
                if (int.TryParse(remS, out rem) && rem <= carriages.Count )
                {
                    correct = true;
                    carriages.Remove(carriages[--rem]);
                    Console.WriteLine($"Вагон номер {rem} удален.");
                }
                else Console.WriteLine($"Введите корректный ответ.");
            } while (!correct);
        }

        public override void GetCapacityOfTrain()
        {
            
            int trainCapacity = (carriages.Count) * 10;
            Console.WriteLine($"Вместимость поезда {trainCapacity} мест");
            Thread.Sleep(1500);
        }

        public override void GetNumOfCarriages()
        {
            Console.WriteLine($"В состав поезда входит {carriages.Count} авгонов.");
            Thread.Sleep(1500);
        }

        public override bool IsAllowedToMove(ref List<bool>allowanceFromEachCarriege)
        {
            if (allowanceFromEachCarriege.Contains(false))
            {
                allowedToMove = false;
                allowanceFromEachCarriege.Clear();
            }
            else
            {
                allowedToMove = true;
            }
            ticketsChecked = true;
            return allowedToMove;
        }

        public override void Move(out bool succeeded)
        {
            succeeded = false;
            if (allowedToMove && ticketsChecked)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                succeeded = true;
                Console.WriteLine("Асцярожна, дзьверы зачыняюцца. Наступны прыпынак - станцыя 'Пухавічы'.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (!ticketsChecked) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Билеты пассажиров не проверены. Перед отправкой проверьте пассажиров.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1500);
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("В поезде находится безбилетник, движение невозможно. Проверьте пассажиров еще раз, и избавьтесь от зайца по-тихому.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1500); 
            }
        }

       
    }
}
