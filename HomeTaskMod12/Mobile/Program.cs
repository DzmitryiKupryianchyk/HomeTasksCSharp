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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Внимание!!! Прежде чем подключаться к сети иностранных операторов необходимо: Вставить сим-карту => подключится к сети вашего оператора => подключить роуминг => подключиться к сети иностранного оператора. ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Если хотите заменить сим-карту, сначала отключитесь от сети.");
            Console.ForegroundColor= ConsoleColor.White;
            Thread.Sleep(2000);
            MobileNetwork life = new Life() {Name = "Life", Country = "Belarus"};
            MobileNetwork mtc = new MTC() { Name = "MTC", Country = "Belarus" };
            MobileNetwork velcom = new Velcom() { Name = "Velcom", Country = "Belarus" };
            MobileNetwork orange = new Orange() { Name = "Orange", Country = "Poland" };
            MobileNetwork elisa = new ElisaEE() { Name = "Elisa.ee", Country = "Estonia" };
            MobileNetwork tele2 = new Tele2() { Name = "Tele2", Country = "Sweden" };
            MobileNetwork kievstar = new Kievstar() { Name = "Kievstar", Country = "Ukraine" };
            MobileNetwork foreign = new ForeignNetworks();

            MobilePhone<MobileNetwork> siemens = new MobilePhone<MobileNetwork>() {Model = "Siemens C75" };
            

            bool finish = false;
            while (!finish) 
            {
                Console.Write("Нажмите ");
                Console.WriteLine("1 - вставить сим-карту");
                Console.WriteLine("        2 - подключиться к сети");
                Console.WriteLine("        3 - отключиться от сети");
                Console.Write($"        4 - ");
                siemens.CheckRoaming();
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
                        Console.WriteLine($"1 - {life.Name}:) - {life.Country}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"               2 - {mtc.Name} - {mtc.Country}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"               3 - {velcom.Name} - {velcom.Country}");
                        Console.WriteLine();
                        Console.WriteLine($"               4 - {orange.Name} - {orange.Country}");
                        Console.WriteLine($"               5 - {elisa.Name} - {elisa.Country}");
                        Console.WriteLine($"               6 - {tele2.Name} - {tele2.Country}");
                        Console.WriteLine($"               7 - {kievstar.Name} - {kievstar.Country}");
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
                            case ConsoleKey.D4:
                                siemens.Connect(orange);
                                break;
                            case ConsoleKey.D5:
                                siemens.Connect(elisa);
                                break;
                            case ConsoleKey.D6:
                                siemens.Connect(tele2);
                                break;
                            case ConsoleKey.D7:
                                siemens.Connect(kievstar);
                                break;
                        }
                        break;   
                    case ConsoleKey.D3:
                        siemens.Disconnect();
                        break;
                    case ConsoleKey.D4:
                        siemens.SwitchRoaming();
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
