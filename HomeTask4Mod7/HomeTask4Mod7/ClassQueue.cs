using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4Mod7
{
    internal class ClassQueue
    {
        Queue <string> myFirstQueue;
        List<string> fillQueue;
        int lenght;
        string argument;
        public ClassQueue(List<string> fillQueue, string argument)
        {
            myFirstQueue = new Queue<string>(fillQueue);
            this.argument = argument;
        }
        public void EnqueueElement(string argument) 
        {
            myFirstQueue.Enqueue(argument);
            Console.WriteLine($"В очередь {nameof(myFirstQueue)} добавлен элемент '{argument}'.");
        }
        public void DequeueOutFromQueue()
        {
            if (myFirstQueue.Count > 0)
            {
                string item = myFirstQueue.Dequeue();
                Console.WriteLine($"Из очереди {nameof(myFirstQueue)} извлечен элемент '{item}'.");
                Console.WriteLine($"Размер очереди - {myFirstQueue.Count} элементов.");
            } else { Console.WriteLine("Очередь пуста. Нечего извлекать."); }
        }
        public void PeekLastItem()
        {
            string item = (string)myFirstQueue.Peek();
            Console.WriteLine($"Последний элемент очереди - '{item}'.");
        }
        public void ToSeeAllQueue()
        {
            object[] array = myFirstQueue.ToArray();
            Console.WriteLine("В очереди содержатся следующие элементы:");
            foreach (object item in array)
            {
                Console.WriteLine(item);

                Thread.Sleep(100);
            }

        }
        public void EraseAllElements()
        {
            myFirstQueue.Clear();
            Console.WriteLine($"Очередь очищена и содержит '{myFirstQueue.Count}' элементов.");
        }

    }
}
