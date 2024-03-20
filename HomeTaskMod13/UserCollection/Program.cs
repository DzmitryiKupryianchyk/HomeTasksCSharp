using System.Text;

namespace UserCollection
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            string intro = "Создать пользовательский список Collection<T> работающий с классами реализующими IComparable. Class должен иметь свойство IdNumber (int).При добавлении список должен сортироваться по id.Заполните список начальными данными.Добавьте в ваш список новый элемент. После каждого изменения списка выводите его на экран.";
            bool finish = false;
            foreach (char c in intro) 
            { 
                Console.Write(c);
                //Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine();

            List<Employee> myEmployees = new List<Employee>();
            myEmployees.Add(new Employee() {IdNumber = 1001, FirstName = "Иван", LastName = "Иванов", Position = "Экономист" });
            myEmployees.Add(new Employee() { IdNumber = 991, FirstName = "Петр", LastName = "Петров", Position = "Бухгалтер" });
            myEmployees.Add(new Employee() { IdNumber = 531, FirstName = "Артем", LastName = "Сидоров", Position = "Менеджер" });
            myEmployees.Add(new Employee() { IdNumber = 679, FirstName = "Дмитрий", LastName = "Васильев", Position = "Геймдизайнер" });
            myEmployees.Add(new Employee() { IdNumber = 428, FirstName = "Евгений", LastName = "Галицкий", Position = "C# разработчик" });
            myEmployees.Add(new Employee() { IdNumber = 1535, FirstName = "Александр", LastName = "Павлов", Position = "3D-художник" });
            CEO ceo = new CEO() {FirstName = "Василий", LastName = "Пупкин" };
            MyCompany myCompany = new MyCompany(myEmployees) {chief = ceo };
            HR hR = new HR();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Штат сотрудников:");
            Console.ForegroundColor = ConsoleColor.White;
            myCompany.ShowEmployees();
            myCompany.Welcome += ceo.WelcomeNewEmployee;
            myCompany.EmployeeHasBeenRemoved += ceo.FareWell;

            NewEmployeeAdded delegateForNewEmployee = new(myCompany.Add);
            RemovedEmployee removedEmployee = new(myCompany.RemoveEmployee);
            

            while (!finish) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1 - Нанять нового сотрудника");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2 - Уволить сотрудника");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("ESC - Завершить работу");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                var choice = Console.ReadKey().Key;
                Console.WriteLine();
                switch (choice) 
                {
                    case ConsoleKey.D1:
                        delegateForNewEmployee(hR.HireNewEmployee());
                        break;
                    case ConsoleKey.D2:
                        removedEmployee(hR.RemoveByIdNumber(myCompany.GetList()));
                        break;
                    case ConsoleKey.Escape:
                        finish = true;
                        break;
                }
            }
            Console.WriteLine("PРабота завершена.");
            Console.ReadKey();
        }
    }
}
