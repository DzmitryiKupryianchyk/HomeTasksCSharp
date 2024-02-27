using System.Text;

namespace Mod_8_HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string intro = "Раскладываем вещи в сумку.";
            string choiceS;
            int choice;
            string answer;
            Bag bag = new Bag();    

            Item item1 = new Item();
            item1.SetName("Телефон");

            Item item2 = new Item();
            item2.SetName("Кошелек");

            Item item3 = new Item();
            item3.SetName("Ключи");

            Item item4 = new Item();
            item4.SetName("Пауэрбанк");

            Item item5 = new Item();
            item5.SetName("Наушники");

            Item item6 = new Item();
            item6.SetName("Книга");

            Item item7 = new Item();
            item7.SetName("Вода");

            Item item8 = new Item();
            item8.SetName("Блокнот");

            Item item9 = new Item();
            item9.SetName("Очки");

            Item item10 = new Item();
            item10.SetName("Танк");

            List<Item> items = new List<Item>() { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10};
            foreach (Char c in intro) 
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine("Вот вещи, которые можно положить в сумку:");    
            foreach (Item item in items) 
            { 
                Console.WriteLine($"{item.GetName()}");
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите 1, открыть или закрыть сумку.");
            Console.WriteLine("Нажмите 2, чтобы добавить вещь в сумку.");
            Console.WriteLine("Нажмите 3, чтобы достать вещь из сумки.");
            Console.WriteLine("Нажмите 4, чтобы посмотреть содержимое сумки.");
            Console.WriteLine("Нажмите 5, завершить работу.");
            do 
            {
                mark2:
                choiceS = Console.ReadLine();
                if (int.TryParse(choiceS, out choice) && choice > 0 && choice < 6)
                {
                    switch (choice) 
                    {
                        case 1 :
                            bag.ChangeBool();
                            break;
                        case 2 :
                            do
                            {
                                Console.WriteLine("Выберите вещь из списка выше и введите ее индекс.");
                                choiceS = Console.ReadLine();
                                if (int.TryParse(choiceS, out choice) && choice > 0 && choice < 11)
                                {
                                    switch (choice)
                                    {
                                        case 1:
                                            bag.AddItem(item1);
                                            break;
                                        case 2:
                                            bag.AddItem(item2);
                                            break;
                                        case 3:
                                            bag.AddItem(item3);
                                            break;
                                        case 4:
                                            bag.AddItem(item4);
                                            break;
                                        case 5:
                                            bag.AddItem(item5);
                                            break;
                                        case 6:
                                            bag.AddItem(item6);
                                            break;
                                        case 7:
                                            bag.AddItem(item7);
                                            break;
                                        case 8:
                                            bag.AddItem(item8);
                                            break;
                                        case 9:
                                            bag.AddItem(item9);
                                            break;
                                        case 10:
                                            bag.AddItem(item10);
                                            break;
                                    }
                                }
                                else { Console.WriteLine("Введите вариант от 1 до 10."); goto mark2; }
                                Console.WriteLine("Добавить еще один предмет? Y/N");
                                mark3:
                                answer = Console.ReadLine();
                                if (answer == "Y" || answer == "y") { Console.WriteLine("Выберите предмет"); }
                                else if (answer == "N" || answer == "n") { break; }
                                else { Console.WriteLine("Введите 'Y' или 'N' "); goto mark3; }
                            } 
                            while (answer == "Y" || answer == "y");
                            break;
                        case 3 :
                            do
                            {
                                Console.WriteLine("Введите индекс элемента для удаления");
                                mark6:
                                choiceS = Console.ReadLine();
                                if (int.TryParse(choiceS, out choice) && choice > 0 && choice < 9) 
                                {
                                    bag.RemoveItem(choice);
                                }
                                else { Console.WriteLine("Введите вариант от 1 до 8."); goto mark6; }
                                Console.WriteLine("Удалить еще один элемент?");
                            mark4:
                                answer = Console.ReadLine();
                                if (answer == "Y" || answer == "y") { Console.WriteLine("Выберите предмет"); }
                                else if (answer == "N" || answer == "n") { break; }
                                else { Console.WriteLine("Введите 'Y' или 'N' "); goto mark4; }
                            } while (answer == "Y" || answer == "y");
                            break;
                        case 4 :
                            bag.LookInside();
                            break;
                        case 5 :
                            Console.WriteLine("Работа завершена.");
                            Thread.Sleep(1000);
                            break;
                    }
                }
                else { Console.WriteLine("Введите вариант от 1 до 5."); }
                Console.WriteLine("Продолжить работу?");
            mark5:
                answer = Console.ReadLine();
                if (answer == "Y" || answer == "y") { Console.WriteLine("Выберите действие"); }
                else if (answer == "N" || answer == "n") { break; }
                else { Console.WriteLine("Введите 'Y' или 'N' "); goto mark5; }
            } while (answer == "Y" || answer == "y");
        }
    }
}
