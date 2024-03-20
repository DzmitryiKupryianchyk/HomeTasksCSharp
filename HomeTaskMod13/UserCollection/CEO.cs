using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection
{
    internal class CEO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void WelcomeNewEmployee(Employee employee) 
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Здравствуйте, уважаемый {employee.FirstName} {employee.LastName} :)");
            Console.WriteLine($"Мы долго искали сотрудника на должность {employee.Position}, и мы очень рады приветствовать вас в нашем коллективе.");
            Console.WriteLine($"Очень надеюсь на долгосрочное плодотворное сотрудничество.");
            Thread.Sleep(3000);
            Console.WriteLine($"С уважением. Директор - {FirstName} {LastName} !");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine();
        }
        public void FareWell(Employee employee) 
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"С сожалением вынужден сообщить, что  {employee.FirstName} {employee.LastName} покинул наш коллектив :(");
            Console.WriteLine($"Открыта вакансия на должность {employee.Position}.");
            Thread.Sleep(3000);
            Console.WriteLine($"С уважением. Директор - {FirstName} {LastName} !");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
