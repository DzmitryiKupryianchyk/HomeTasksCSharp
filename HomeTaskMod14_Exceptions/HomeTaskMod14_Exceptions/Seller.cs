using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod14_Exceptions
{
    internal class Seller
    {
        public string Name { get; set; }

        public bool isOnDuty = false;

        public void AddGoods(List<Goods> goodsList, Store<Goods> store) 
        {
            Console.WriteLine("Выберите товар со склада для добавления в магазин.");
            Console.WriteLine("1 - молоко.");
            Console.WriteLine("2 - хлеб.");
            Console.WriteLine("3 - сок.");
            Console.WriteLine("4 - блокнот");
            Console.WriteLine("5 - футболка");
            Console.WriteLine("6 - очки");
            Console.WriteLine("7 - наушники");
            Console.WriteLine("8 - пиво");
            Console.WriteLine("9 - Jagermeister");
            bool finish = false;
            while (!finish)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ESC - закончить добавление товара");
                Console.ForegroundColor= ConsoleColor.White;
                var choice = Console.ReadKey().Key;
                switch (choice) 
                {
                    case ConsoleKey.D1:
                        bool containsName = goodsList.Any(item => item.Name == "молоко");
                        try
                        {
                            if (containsName)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                throw new AdditionException();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                goodsList.Add(store.milk);
                                Console.Write("Товар");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($" {store.milk.Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("добавлен в магазин.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        catch (AdditionException ex) 
                        {
                            ex.Message();
                        }
                        break;
                    case ConsoleKey.D2:
                        containsName = goodsList.Any(item => item.Name == "хлеб");
                        try
                        {
                            if (containsName)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                throw new AdditionException();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                goodsList.Add(store.bread);
                                Console.Write("Товар");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($" {store.bread.Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("добавлен в магазин.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        catch (AdditionException ex)
                        {
                            ex.Message();
                        }
                        break;
                    case ConsoleKey.D3:
                        containsName = goodsList.Any(item => item.Name == "сок");
                        try
                        {
                            if (containsName)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                throw new AdditionException();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                goodsList.Add(store.juice);
                                Console.Write("Товар");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($" {store.juice.Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("добавлен в магазин.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }catch (AdditionException ex) 
                        {
                            ex.Message();
                        }
                        break;
                    case ConsoleKey.D4:
                        containsName = goodsList.Any(item => item.Name == "блокнот");
                        try
                        {
                            if (containsName)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                throw new AdditionException();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                goodsList.Add(store.noteBook);
                                Console.Write("Товар");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($" {store.noteBook.Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("добавлен в магазин.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }catch(AdditionException ex) 
                        {
                            ex.Message();
                        }
                        break;
                    case ConsoleKey.D5:
                        containsName = goodsList.Any(item => item.Name == "футболка");
                        try
                        {
                            if (containsName)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                throw new AdditionException();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                goodsList.Add(store.tShirt);
                                Console.Write("Товар");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($" {store.tShirt.Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("добавлен в магазин.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        catch (AdditionException ex) 
                        {
                            ex.Message();
                        }
                        break;
                    case ConsoleKey.D6:
                        containsName = goodsList.Any(item => item.Name == "очки");
                        try
                        {
                            if (containsName)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                throw new AdditionException();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                goodsList.Add(store.glasses);
                                Console.Write("Товар");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($" {store.glasses.Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("добавлен в магазин.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        catch (AdditionException ex)
                        {
                            ex.Message();
                        }
                        break;
                    case ConsoleKey.D7:
                        containsName = goodsList.Any(item => item.Name == "наушники");
                        try
                        {
                            if (containsName)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                throw new AdditionException();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                goodsList.Add(store.headphones);
                                Console.Write("Товар");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($" {store.headphones.Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("добавлен в магазин.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        catch (AdditionException ex) 
                        {
                            ex.Message();
                        }
                        break;
                    case ConsoleKey.D8:
                        containsName = goodsList.Any(item => item.Name == "пиво");
                        try
                        {
                            if (containsName)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                throw new AdditionException();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                goodsList.Add(store.beer);
                                Console.Write("Товар");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($" {store.beer.Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("добавлен в магазин.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        catch (AdditionException ex) 
                        { 
                            ex.Message();
                        }
                        break;
                    case ConsoleKey.D9:
                        containsName = goodsList.Any(item => item.Name == "jagermeister");
                        try
                        {
                            if (containsName)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                throw new AdditionException();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                goodsList.Add(store.liquor);
                                Console.Write("Товар");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($" {store.liquor.Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("добавлен в магазин.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        catch (AdditionException ex) 
                        { 
                            ex.Message();
                        }
                        break;
                    case ConsoleKey.Escape:
                        finish = true;
                        break;
                }
            }
        }

        public void RemoveGoods(List<Goods> goodsList) 
        {
            string exit = "выйти";
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ведите название товара, который хотите вернуть:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            bool finish = false;
            while (!finish)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Чтобы закончить удаление введите 'выйти'.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                foreach (Goods goods in goodsList) 
                { 
                    Console.ForegroundColor = ConsoleColor.Yellow; 
                    Console.WriteLine($"Название - {goods.Name} цена - {goods.Price} руб.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                string choice = Console.ReadLine();
                for (int i = 0; i < goodsList.Count; i++ )
                {
                    if (choice == goodsList[i].Name)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{goodsList[i].Name} удален из магазина");
                        Console.ForegroundColor = ConsoleColor.White;
                        goodsList.Remove(goodsList[i]);
                    }
                }
                if (choice == exit)
                {
                    finish = true;
                    break;
                }
            }
        }

        public bool GetStartedOrLeave() 
        {
            Console.WriteLine();
            if (!isOnDuty)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Продавец приступил к выполнению обязанностей.");
                Console.ForegroundColor = ConsoleColor.White;
                isOnDuty = true;
                return isOnDuty;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Продавец покинул рабочее место.");
                Console.ForegroundColor = ConsoleColor.White;
                isOnDuty = false;
                return isOnDuty;
            }
        }
        public void Sell(List<Goods> goodsList, Buyer buyer, ref double repayment) 
        {
            if (buyer.hasBuyerPaid)
            {
                for (int i = 0; i < buyer.shopping.Count; i++)
                {
                    try
                    {
                        if (buyer.shopping[i] is Alcohol && buyer.Age >= 18)
                        {
                            buyer.BuyersBag.Add(buyer.shopping[i]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Товар - ");
                            Console.Write($"{buyer.BuyersBag[i].Name} ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("цена - ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{buyer.BuyersBag[i].Price} ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Оплачено.");
                            Console.WriteLine();
                            Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (buyer.shopping[i] is Alcohol && buyer.Age < 18)
                        {
                            throw new ProhibitedToSellAlcoholException();
                        }
                        else
                        {
                            buyer.BuyersBag.Add(buyer.shopping[i]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Товар - ");
                            Console.Write($"{buyer.BuyersBag[i].Name} ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("цена - ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{buyer.BuyersBag[i].Price} ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Оплачено.");
                            Console.WriteLine();
                            Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    catch (ProhibitedToSellAlcoholException ex)
                    {
                        ex.Message();
                        buyer.wallet += buyer.shopping[i].Price;
                        goodsList.Add(buyer.shopping[i]);
                        repayment = buyer.shopping[i].Price;
                        Console.WriteLine($"товар {buyer.shopping[i].GetType().Name} {buyer.shopping[i].Name} не был продан несовершеннолетнему и возвращен на место.");
                        Console.WriteLine($"Клиенту возвращено {buyer.shopping[i].Price} рублей");
                        //buyer.shopping.Remove(buyer.shopping[i]);
                        buyer.CalculateTotalPrice();
                    }
                }
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Спасибо за покупку :)");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1500);
                buyer.shopping.Clear();
            }
        }

        public double GiveAwayCash() 
        { 
            return 0; 
        }

        public double CheckPayment(double payment) 
        {
            double recievedCash = payment;
            return recievedCash;

        }
    }
}
