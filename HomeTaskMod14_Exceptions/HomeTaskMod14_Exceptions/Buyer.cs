namespace HomeTaskMod14_Exceptions
{
    internal class Buyer
    {
        public event DelegateToSeller PaymentHasBeenCompleted;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double sumToPay = 0;
        public bool hasBuyerPaid = false;
        public bool cardIsBlocked = false;

        public List<Goods> shopping = new List<Goods>();
        public List<Goods> BuyersBag = new List<Goods>();

        public int Age { get; set; }

        public double wallet;

        public Buyer(double wallet)
        {
            this.wallet = wallet;
        }

        public double Pay()
        {
            Console.WriteLine();
            try
            {
                if (wallet < sumToPay)
                {
                    throw new LackOfMoneyException("В магазине есть банкомат.");
                }
                else if (shopping.Count == 0)
                {
                    throw new EmptyListException("Пополните корзинку.");
                }
                else
                {
                    foreach (var v in shopping)
                    {
                        wallet -= v.Price;
                    }
                    hasBuyerPaid = true;
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Оплата прошла успешно :)");
                    Console.ForegroundColor = ConsoleColor.White;
                    PaymentHasBeenCompleted(sumToPay);
                }
            }
            catch (LackOfMoneyException ex) { Console.WriteLine(ex.Message); }
            catch (EmptyListException ex) { Console.WriteLine(ex.Message); }
            return wallet;
        }

        public void AddToBasket(Shop shop)
        {
            Console.WriteLine();
            Console.WriteLine("Выберите товар для добавления в корзину. Нажмите ESC если достаточно.");
            bool finish = false;
            while (!finish)
            {
                shop.ToSeeAssortment();
                var choice = Console.ReadKey().Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        try
                        {
                            if (shop.goodsList[0] != null)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"{shop.goodsList[0].Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"добавлен ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"в продуктовую корзинку.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.Write("ESC ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" - закончить добавление продуктов в корзину.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                Console.WriteLine();
                                shopping.Add(shop.goodsList[0]);
                                shop.goodsList.RemoveAt(0);
                                sumToPay = 0;
                                CalculateTotalPrice();
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{ex.Message} Ошибка. Полка пуста. Нет такого товара.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.D2:
                        try
                        {
                            if (shop.goodsList[1] != null)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"{shop.goodsList[1].Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"добавлен ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"в продуктовую корзинку.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.Write("ESC ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" - закончить добавление продуктов в корзину.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                Console.WriteLine();
                                shopping.Add(shop.goodsList[1]);
                                shop.goodsList.RemoveAt(1);
                                sumToPay = 0;
                                CalculateTotalPrice();
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{ex.Message} Ошибка. Полка пуста. Нет такого товара.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.D3:
                        try
                        {
                            if (shop.goodsList[2] != null)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"{shop.goodsList[2].Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"добавлен ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"в продуктовую корзинку.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.Write("ESC ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" - закончить добавление продуктов в корзину.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                Console.WriteLine();
                                shopping.Add(shop.goodsList[2]);
                                shop.goodsList.RemoveAt(2);
                                sumToPay = 0;
                                CalculateTotalPrice();
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{ex.Message} Ошибка. Полка пуста. Нет такого товара.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.D4:
                        try
                        {
                            if (shop.goodsList[3] != null)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"{shop.goodsList[3].Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"добавлен ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"в продуктовую корзинку.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.Write("ESC ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" - закончить добавление продуктов в корзину.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                Console.WriteLine();
                                shopping.Add(shop.goodsList[3]);
                                shop.goodsList.RemoveAt(3);
                                sumToPay = 0;
                                CalculateTotalPrice();
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{ex.Message} Ошибка. Полка пуста. Нет такого товара.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.D5:
                        try
                        {
                            if (shop.goodsList[4] != null)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"{shop.goodsList[4].Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"добавлен ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"в продуктовую корзинку.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.Write("ESC ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" - закончить добавление продуктов в корзину.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                Console.WriteLine();
                                shopping.Add(shop.goodsList[4]);
                                shop.goodsList.RemoveAt(4);
                                sumToPay = 0;
                                CalculateTotalPrice();
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{ex.Message} Ошибка. Полка пуста. Нет такого товара.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.D6:
                        try
                        {
                            if (shop.goodsList[5] != null)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"{shop.goodsList[5].Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"добавлен ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"в продуктовую корзинку.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.Write("ESC ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" - закончить добавление продуктов в корзину.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                Console.WriteLine();
                                shopping.Add(shop.goodsList[5]);
                                shop.goodsList.RemoveAt(5);
                                sumToPay = 0;
                                CalculateTotalPrice();
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{ex.Message} Ошибка. Полка пуста. Нет такого товара.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.D7:
                        try
                        {
                            if (shop.goodsList[6] != null)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"{shop.goodsList[6].Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"добавлен ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"в продуктовую корзинку.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.Write("ESC ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" - закончить добавление продуктов в корзину.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                Console.WriteLine();
                                shopping.Add(shop.goodsList[6]);
                                shop.goodsList.RemoveAt(6);
                                sumToPay = 0;
                                CalculateTotalPrice();
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{ex.Message} Ошибка. Полка пуста. Нет такого товара.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.D8:
                        try
                        {
                            if (shop.goodsList[7] != null)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"{shop.goodsList[7].Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"добавлен ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"в продуктовую корзинку.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.Write("ESC ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" - закончить добавление продуктов в корзину.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                Console.WriteLine();
                                shopping.Add(shop.goodsList[7]);
                                shop.goodsList.RemoveAt(7);
                                sumToPay = 0;
                                CalculateTotalPrice();
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{ex.Message} Ошибка. Полка пуста. Нет такого товара.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.D9:
                        try
                        {
                            if (shop.goodsList[8] != null)
                            {
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"{shop.goodsList[8].Name} ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"добавлен ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write($"в продуктовую корзинку.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine();
                                Console.Write("ESC ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" - закончить добавление продуктов в корзину.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                                Console.WriteLine();
                                shopping.Add(shop.goodsList[8]);
                                shop.goodsList.RemoveAt(8);
                                sumToPay = 0;
                                CalculateTotalPrice();
                            }
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{ex.Message} Ошибка. Полка пуста. Нет такого товара.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.Escape:
                        finish = true;
                        break;
                }
            }
        }

        public void RemoveFromBasket()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ведите название товара, который хотите вернуть:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            bool finish = false;
            while (!finish)
            {
                ToSeeShoppingCart();
                string choice = Console.ReadLine();
                foreach (var c in shopping)
                {
                    if (choice == c.Name)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{c.Name} удален из корзины");
                        Console.ForegroundColor = ConsoleColor.White;
                        shopping.Remove(c);
                        CalculateTotalPrice();
                        finish = true;
                        break;
                    }
                }
                if (!finish) { Console.WriteLine("В корзинке нет такого товара. Попробуйте еще раз"); }
            }
        }

        public void ToSeeShoppingCart()
        {
            Console.WriteLine();
            try
            {
                if (shopping.Count <= 0)
                {
                    throw new EmptyListException("Пополните корзинку.");
                }
                else
                {
                    foreach (var s in shopping)
                    {
                        Console.WriteLine($"Название товара - {s.Name} цена - {s.Price}");
                    }
                }
            }
            catch (EmptyListException ex) { Console.WriteLine(ex.Message); }
        }

        public double CalculateTotalPrice()
        {
            sumToPay = 0;
            if (shopping.Count == 0)
            {
                sumToPay = 0;

            }
            else
            {
                foreach (var s in shopping)
                {
                    sumToPay += s.Price;
                }
            }

            return sumToPay;
        }

        public void EraseSumOfPay()
        {
            sumToPay = 0;
        }

        public void RefillWallet()
        {
            Console.WriteLine();
            if (!cardIsBlocked)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Введите пин-код вашей карты:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                Подсказка - 1234");
                Console.ForegroundColor = ConsoleColor.White;

                bool correct = false;
                int pin = 0;
                for (int i = 1; i < 4; i++)
                {
                    string pinS = Console.ReadLine();
                    if (int.TryParse(pinS, out pin))
                    {
                        if (pin == 1234)
                        {
                            correct = true;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Пин-код введен корректно.");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Неправильный Пин-код!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else { Console.WriteLine("Ошибка. Неверный формат данных, либо пустая строка."); }
                }

                if (correct)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Какую сумму хотите обналичить?");
                    bool finish = false;
                    while (!finish)
                    {
                        string sumS = Console.ReadLine();
                        if (int.TryParse(sumS, out int sum))
                        {
                            wallet += sum;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Возьмите ваши наличные.");
                            Console.ForegroundColor = ConsoleColor.White;
                            finish = true;
                        }
                        else { Console.WriteLine("Ошибка. Неверный формат данных, либо пустая строка."); }
                    }
                }
                else
                {
                    cardIsBlocked = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка. Пин-код введен неверно 3 раза. Карта заблокирова");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Карта заблокирована. Обратитесь в банк.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2000);
            }
        }
    }
}
