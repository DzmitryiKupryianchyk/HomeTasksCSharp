using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3Mod7
{
    internal class Class1
    {
        public class ClassStack
        {
            Stack<string> myFirstStack;
            string argument;
            public ClassStack(List<string> fillStack, string argument)
            {
                myFirstStack = new Stack<string>(fillStack);
                this.argument = argument;

            }
            public void PushToStack(string argument) 
            { 
               myFirstStack.Push(argument);
                Console.WriteLine($"В стек {nameof(myFirstStack)} добавлен элемент '{argument}'.");
            }
            public void PopOutFromStack()
            {
                if (myFirstStack.Count > 0)
                {
                    string item = myFirstStack.Pop();
                    Console.WriteLine($"Из стека {nameof(myFirstStack)} извлечен элемент '{item}'.");
                    Console.WriteLine($"Размер стека - {myFirstStack.Count} элементов.");
                } else { Console.WriteLine("Стек пуст. Нечего извлекать."); }
            }
            public void PeekLastItem()
            {
                string item = myFirstStack.Peek();
                Console.WriteLine($"Последний элемент стека - '{item}'.");
            }
            public void ToSeeAllStack()
            {
                object[] array = myFirstStack.ToArray();
                Console.WriteLine("В стеке содержатся следующие элементы:");
                foreach (object item in array)
                {
                    Console.WriteLine(item);
                   
                    Thread.Sleep(100);
                } 
            }
            public void EraseAllElements()
            {
                myFirstStack.Clear();
                Console.WriteLine($"Стек очищен и содержит '{myFirstStack.Count}' элементов.");
            }

        }
    }
}
