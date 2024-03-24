using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HomeTaskMod14_Exceptions
{
    delegate double DelegateToSeller(double payment);
    delegate void DelegateCashBoxIsFilled(double bag);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            bool finish = false;
            bool enough = false;
            bool buyerActivated = false;
            string intro = "Создать магазин с продавцом и покупателем. Реализовать исключения. Для начала работы нужно 'позвать' продавца на работу. Если у покупателя не достаточно денег-можно 'снять' любую сумму. Если покупатель не достиг 18 лет, продавец не продаст алкоголь. Если сумма в кассе достигла дневной нормы, приезжает инкассация и забирает наличные деньги";
            foreach (char c in intro) 
            { 
                Console.Write(c);
            }
            Console.WriteLine();
            Console.WriteLine();

            Store<Goods> store = new Store<Goods>();
            List<Goods> listOfGoods = new List<Goods>();
            listOfGoods.Add(store.milk);
            listOfGoods.Add(store.bread);
            listOfGoods.Add(store.juice);
            listOfGoods.Add(store.tShirt);
            listOfGoods.Add(store.glasses);
            listOfGoods.Add(store.headphones);
            listOfGoods.Add(store.noteBook);
            listOfGoods.Add(store.beer);
            listOfGoods.Add(store.liquor);
            Collector collector = new Collector();
            Buyer buyer = new Buyer(50) { FirstName = "Ivan", LastName = "Ivanov", Age = 17 };
            Seller seller = new Seller() { Name = "Sam" };
            Shop shop = new Shop(listOfGoods) {Seller = seller, Buyer = buyer, Store = store};
            DelegateToSeller sellIfPaid = new(shop.AddToCashBox);
            buyer.PaymentHasBeenCompleted += sellIfPaid;
            DelegateCashBoxIsFilled cashBoxIsFilled = new(collector.CollectMoney);
            shop.CashBoxIsFull += cashBoxIsFilled;


            while (!finish)
            {
                try
                {
                    if (shop == null)
                    {
                        throw new InvalidOperationException();
                    }
                    else {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("                                                        Денег в кассе - ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{shop.cashBox} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"руб.");
                        Console.Write(" Дневная норма - ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{shop.maxSumOfCashBox} ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"руб.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        if (seller.isOnDuty)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Продавец работает");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Продавец отсутствует на рабочем месте.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }
                    }
                }
                catch (InvalidOperationException ex) 
                {
                    Thread.Sleep(1000);
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine($"{ex.Message} Магазин ликвидирован. Дальнейшая работа невозможна");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                    return;
                }

                if (buyerActivated) 
                {
                    Console.WriteLine();
                    Console.Write("                                Клиент - ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{buyer.FirstName} {buyer.LastName}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" B кошельке - ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{buyer.wallet} ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("рублей. ");
                    Console.Write("Сумма покупок - ");
                    if (buyer.wallet >= buyer.sumToPay) { Console.ForegroundColor = ConsoleColor.Green; }
                    else Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{buyer.sumToPay}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" рублей.");
                    Console.WriteLine();
                }


                Console.WriteLine("Нажмите:");
                if (seller.isOnDuty)
                    {
                        Console.Write("1 - чтобы продавец ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("покинул ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("рабочее место.");
                        Console.WriteLine();
                    }
                    else 
                    {
                        Console.Write("1 - чтобы продавец ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("пришел ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("на рабочее место.");
                        Console.WriteLine();
                }
                Console.WriteLine("2 - покупатель добавил что-нибудь в корзину.");
                Console.WriteLine("3 - чтобы покупатель вернул что-нибудь из корзиы на место.");
                Console.WriteLine("4 - чтобы покупатель оплатил покупку.");
                Console.WriteLine("5 - покупатель снял наличные и пополнил кошелек.");
                Console.WriteLine("6 - чтобы продавец добавил товар на полку.");
                Console.WriteLine("7 - чтобы продавец убрал товар.");
                Console.Write("8 - чтобы ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ликвидировать ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("магазин.");
                Console.WriteLine("ESC - закончить работу.");
                Console.WriteLine();

                var choice = Console.ReadKey().Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                            seller.GetStartedOrLeave();
                            break;
                    case ConsoleKey.D2:
                        try
                        {
                            if (seller.isOnDuty)
                            {
                                buyerActivated = true;
                                buyer.AddToBasket(shop);
                                break;
                            }
                            else
                            {
                                throw new SellerIsNotOnDutyException(" Приведите продавца на работу.");
                            }
                        }
                        catch (SellerIsNotOnDutyException ex)
                        {
                            Console.WriteLine(ex.Message);
                            break;
                        }
                    case ConsoleKey.D3:
                        try
                        {
                            if (seller.isOnDuty)
                            {
                                buyerActivated = true;
                                buyer.RemoveFromBasket();
                                break;
                            }
                            else
                            {
                                throw new SellerIsNotOnDutyException(" Приведите продавца на работу.");
                            }
                        }
                        catch (SellerIsNotOnDutyException ex)
                        {
                            Console.WriteLine(ex.Message);
                            break;
                        }
                    case ConsoleKey.D4:
                        try
                        {
                            if (seller.isOnDuty)
                            {
                                buyerActivated = true;
                                buyer.Pay();
                                break;
                            }
                            else
                            {
                                throw new SellerIsNotOnDutyException(" Приведите продавца на работу.");
                            }
                        }
                        catch (SellerIsNotOnDutyException ex)
                        {
                            Console.WriteLine(ex.Message);
                            break;
                        }
                    case ConsoleKey.D5:
                        try
                        {
                            if (seller.isOnDuty)
                            {
                                
                                buyer.RefillWallet();
                                break;
                            }
                            else
                            {
                                throw new SellerIsNotOnDutyException("Приведите продавца на работу.");
                            }
                        }
                        catch (SellerIsNotOnDutyException ex)
                        {
                            Console.WriteLine(ex.Message);
                            break;
                        }
                    case ConsoleKey.D6:
                        try
                        {
                            if (seller.isOnDuty)
                            {
                                shop.RefillShelves();
                                break;
                            }
                            else
                            {
                                throw new SellerIsNotOnDutyException("Приведите продавца на работу.");
                            }
                        }
                        catch (SellerIsNotOnDutyException ex)
                        {
                            Console.WriteLine(ex.Message);
                            break;
                        }
                    case ConsoleKey.D7:
                        try
                        {
                            if (seller.isOnDuty)
                            {

                                shop.EmptyShelves();
                                break;
                            }
                            else
                            {
                                throw new SellerIsNotOnDutyException("Приведите продавца на работу.");
                            }
                        }
                        catch (SellerIsNotOnDutyException ex)
                        {
                            Console.WriteLine(ex.Message);
                            break;
                        }
                    case ConsoleKey.D8:
                        DestroyShop(ref shop);
                        break;
                    case ConsoleKey.Escape:
                        finish = true;
                        break;
                }
            }
        }

        public static void DestroyShop(ref Shop shop) 
        {
            try 
            {
                if (shop.goodsList.Count != 0)
                {
                    throw new InvalidOperationException();
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Thread.Sleep(1000);
                    Console.WriteLine("Магазин ликвидирован.");
                    shop = null;
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1000);
                }
            }
            catch (InvalidOperationException ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(1000);
                Console.WriteLine($"{ex.Message} Ошибка. Недопустимая операция. В магазине еще остались товары. Удалите. ");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
            }
        }
    }
}
