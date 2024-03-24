using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUniqueException
{
    internal class StringWorker
    {
        public void Worker(string data) 
        {
            if (string.IsNullOrEmpty(data))
            {

                throw new Argument_shouldntBeNullException("Не оставляйте строку пустой");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
