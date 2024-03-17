using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    abstract class MobileNetwork
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public bool roaming;
        
        public abstract void ShowServices();

        public void IsRoaming() 
        {
            if (!roaming) 
            { 
                Console.Write("Роуминг ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("отключен. ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Подключить?");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else 
            {
                Console.Write("Роуминг");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Подключен.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Отключить?");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Roaming() 
        {
            if (!roaming)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Роуминг успешно подключен.");
                Console.ForegroundColor = ConsoleColor.White;
                bool roam = true;
                roaming = roam;
                Console.WriteLine(roaming);
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Роуминг отключен.");
                Console.ForegroundColor = ConsoleColor.White;
                bool roam = false;
                roaming = roam;
            }
  
        }
    }
}
