using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod14_Exceptions
{
    internal class Shop
    {
        public event DelegateCashBoxIsFilled CashBoxIsFull;

        public double cashBox;
        public double maxSumOfCashBox = 100;

        public Store<Goods> Store { get; set; }

        public Seller Seller { get; set; }

        public Buyer Buyer { get; set; }

        public List<Goods> goodsList;

        public Shop(List<Goods> goodsList)
        {
            this.goodsList = goodsList;
        }

        public void ToSeeAssortment() 
        {
            Console.WriteLine();
            int count = 1;
            foreach (var item in goodsList) 
            {
                Console.WriteLine($"{count} - тип - {item.GetType().Name} наименование - {item.Name}. Цена - {item.Price}");
                count++;
            }
            Console.WriteLine();
        }

        public void RefillShelves()
        {
            Seller.AddGoods(goodsList, Store);
        }

        public void EmptyShelves() 
        {
            Seller.RemoveGoods(goodsList);
        }

        public double AddToCashBox(double payment)
        {
            double repayment = 0.0;
            Seller.Sell(goodsList, Buyer, ref repayment);
            cashBox += payment - repayment;
            if (cashBox >= maxSumOfCashBox) 
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("План выручки выполнен. Ожидайте инкассацию");
                Console.ForegroundColor= ConsoleColor.White;
                Thread.Sleep(2500);
                CashBoxIsFull(GiveMoneyFromCashBoxToCollectot());
            }
            Buyer.EraseSumOfPay();
            return cashBox; 
        }

        public double GiveMoneyFromCashBoxToCollectot() 
        {
            double bag;
            bag = cashBox;
            cashBox = 0;
            return bag;
        }
    }
}
