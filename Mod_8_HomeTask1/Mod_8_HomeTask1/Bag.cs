using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mod_8_HomeTask1
{
    internal class Bag
    {
        private Item [] myBag = new Item [8];
        private bool isOpen = true;

        public bool ChangeBool() 
        {
            if (isOpen) { isOpen = false; Console.WriteLine("Теперь сумка закрыта"); }
            else { isOpen = true; Console.WriteLine("Теперь сумка открыта"); }
            return isOpen;
        }
        public void AddItem(Item item) 
        { 
            if (!isOpen) 
            {
                Console.WriteLine("Сумка закрыта");
                return;
            }
            for (int i = 0; i < myBag.Length; i++) 
            {
                if (i == myBag.Length - 1 && myBag[i] != null)
                {
                    Console.WriteLine("Сумка полна. Удалите что-нибудь.");
                }
                else if (item.Equals(myBag[i]))
                {
                    Console.WriteLine($"{item.GetName()} уже в сумке. Выберите что-то другое.");
                    break;
                }
                else if (myBag[i] == null)
                {
                    myBag[i] = item;
                    Console.WriteLine($"{item.GetName()} добавлен в сумку с индексом {i+1}.");
                    break;
                }
            }
        }
        public void RemoveItem(int index) 
        {
            if (!isOpen)
            {
                Console.WriteLine("Сумка закрыта");
            }
            else if(myBag[index - 1] == null) { Console.WriteLine("Такого элемента в сумке нет."); }
            else 
            {
                Console.WriteLine($"элемент {myBag[index - 1].GetName()} с индексом {index} удален из сумки.");
                myBag[index - 1] = null;
            }
        }
        public void LookInside() 
        {
            int index = 1;
            Console.WriteLine("Содержимое сумки:");
            foreach (Item item in myBag) 
            {
                if(item == null) Console.WriteLine($"{index} - Слот пуст.");
                else Console.WriteLine($"{index} - {item.GetName()}");
                index++;
            }
        }
    }
}
