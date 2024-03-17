using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Mobile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
             
            string intro = "Создать тип 'MobileNetwork' и дженерик тип 'MobilePhone<T>'. Ограничения: Т-MobileNetwork тип.";
            foreach (char c in intro) 
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
            MobileNetwork life = new Life() {Name = "Life", Country = "Belarus"};
            MobileNetwork mtc = new MTC() { Name = "MTC", Country = "Belarus" };
            MobileNetwork velcom = new Velcom() { Name = "Velcom", Country = "Belarus" };
            MobilePhone<MobileNetwork> siemens = new MobilePhone<MobileNetwork>() {Model = "Siemens C75" };
            

            bool finish = false;
            while (!finish) 
            {
                Console.Write("Нажмите ");
                Console.WriteLine("1 - вставить сим-карту");
                Console.WriteLine("        2 - подключиться к сети");
                Console.WriteLine("        3 - отключиться от сети");
                Console.WriteLine("        ESC - завершить работу");
                var choice = Console.ReadKey().Key;
                Console.WriteLine();
                switch (choice) 
                {
                    case ConsoleKey.D1:
                        Console.Write("Выберите сим-карту:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" 1 - Life:)");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                    2 - MTC");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("                    3 - Velcom");
                        Console.ForegroundColor = ConsoleColor.White;
                        var chooseSim = Console.ReadKey().Key;
                        Console.WriteLine();
                        switch (chooseSim) 
                        {
                            case ConsoleKey.D1:
                                siemens.SimCard = "Life";
                                Console.Write("Вставлена сим-карта ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Life:)");
                                Console.ForegroundColor= ConsoleColor.White;
                                break;
                            case ConsoleKey.D2:
                                siemens.SimCard = "MTC";
                                Console.Write("Вставлена сим-карта ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("MTC");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case ConsoleKey.D3:
                                siemens.SimCard = "Velcom";
                                Console.Write("Вставлена сим-карта ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Velcom");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;

                        }
                        break;
                    case ConsoleKey.D2:
                        Console.Write("Выберите сеть: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("1 - Life:)");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("               2 - MTC");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("               3 - Velcom");
                        Console.ForegroundColor = ConsoleColor.White;
                        var chooseNetWork = Console.ReadKey().Key;
                        Console.WriteLine();
                        switch (chooseNetWork) 
                        {
                            case ConsoleKey.D1:
                                siemens.Connect(life);
                                break; 
                            case ConsoleKey.D2:
                                siemens.Connect(mtc);
                                break; 
                            case ConsoleKey.D3:
                                siemens.Connect(velcom);
                                break;
                        }
                        break;   
                    case ConsoleKey.D3:
                        siemens.Disconnect();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("PРабота завершена.");
                        return;

                }
            }
            Console.ReadKey();
        }
    }
}
