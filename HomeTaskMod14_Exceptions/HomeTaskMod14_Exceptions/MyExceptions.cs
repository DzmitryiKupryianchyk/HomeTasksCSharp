using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskMod14_Exceptions
{
    internal class EmptyListException : Exception
    {
        private readonly string message;

        public EmptyListException(string message) : base("Ошибка. Корзинка пуста :( " + message) 
        { 
            this.message = message;
        }
    }

    internal class LackOfMoneyException : Exception 
    {
        private readonly string message;

        public LackOfMoneyException(string message) : base("Ошибка. В кошельке недостаточно средств :( " + message)
        { 
            this.message = message;
        }
    }

    internal class ProhibitedToSellAlcoholException : Exception
    {
        public void Message()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка. Покупатель несовершеннолетний. Продажа алкоголя запрещена!!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    internal class SellerIsNotOnDutyException : Exception
    {
        private readonly string message;

        public SellerIsNotOnDutyException(string message) : base("Ошибка. Продавец не на работе. Функционал мaгазина недоступен. " + message) 
        { 
            this.message = message;
        }
    }

    internal class AdditionException : Exception
    {
        public void Message()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка. Товар уже есть в наличии.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
