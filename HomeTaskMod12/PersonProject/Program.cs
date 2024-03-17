using System.Text;

namespace PersonProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Person> list = new List<Person>();
            Person p1 = new Person("Arnold", "Schwarzenegger", 76, GenderEnum.male);
            list.Add(p1);
            Person p2 = new Person("Sylvester", "Stallone", 77, GenderEnum.male);
            list.Add(p2);
            Person p3 = new Person("Jackie", "Chan", 69, GenderEnum.male);
            list.Add(p3);
            Person p4 = new Person("Nicolas", "Cage", 60, GenderEnum.male);
            list.Add(p4);
            Person p5 = new Person("Ivan", "Ivanov", 33, GenderEnum.male);
            list.Add(p5);
            Person p6 = new Person("Angelina", "Jolie", 48, GenderEnum.female);
            list.Add(p6);
            Person p7 = new Person("Scarlett", "Johansson", 39, GenderEnum.female);
            list.Add(p7);
            Person p8 = new Person("Keira", "Knightley", 38, GenderEnum.female);
            list.Add(p8);
            Person p9 = new Person("Cate", "Blanchett", 54, GenderEnum.female);
            list.Add(p9);
            Person p10 = new Person("Jennifer", "Aniston", 55, GenderEnum.female);
            list.Add(p10);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Список имен до сортировки:");
            Console.ForegroundColor = ConsoleColor.White;
            int count = 1;
            foreach (Person p in list) 
            {
                Console.WriteLine($"{count} - {p.GetFirstName()} {p.GetLastName()}. Пол - {p.GetGender()}, возраст - {p.GetAge()}");
                count++;
            }
            count = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Нажмите 1, чтобы посмотреть оригинальный список. Нажмите 2, чтобы отсортировать список с помощью 'IComparable'. Нажмите 3, чтобы отсортировать список с помощью 'IComparer'. Escape - для завершения работы.") ;
            Console.ForegroundColor = ConsoleColor.White;
            bool finish = false ;
            while (!finish)
            {
                var choice = Console.ReadKey().Key;
                switch (choice) 
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Список имен до сортировки:");
                        Console.ForegroundColor = ConsoleColor.White;
                        
                        count = 1;
                        foreach (Person p in list)
                        {
                            Console.WriteLine($"{count} - {p.GetFirstName()} {p.GetLastName()}. Пол - {p.GetGender()}, возраст - {p.GetAge()}");
                            count++;
                        }
                        count = 1;
                        break;
                    case ConsoleKey.D2:
                        List<Person> sortedByIcomparableList = new List<Person>(list);
                        sortedByIcomparableList.Sort();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Список имен после сортировки 'Icomparable':");
                        Console.ForegroundColor = ConsoleColor.White;
                        foreach (Person p in sortedByIcomparableList)
                        {
                            Console.WriteLine($"{count} - {p.GetFirstName()} {p.GetLastName()}. Пол - {p.GetGender()}, возраст - {p.GetAge()}");
                            count++;
                        }
                        count = 1;
                        break;
                    case ConsoleKey.D3:
                        PersonComparer compare = new PersonComparer();
                        List<Person> sortedByComparerList = new List<Person>(list);
                        sortedByComparerList.Sort();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Список имен после сортировки 'PersonComparer':");
                        Console.ForegroundColor = ConsoleColor.White;
                        foreach (Person p in sortedByComparerList)
                        {
                            Console.WriteLine($"{count} - {p.GetFirstName()} {p.GetLastName()}. Пол - {p.GetGender()}, возраст - {p.GetAge()}");
                            count++;
                        }
                        count = 1;
                        break;
                    case ConsoleKey.Escape:
                        finish = true;
                        return;
                }
                
            }
            Console.WriteLine("Завершение работы.");
            Console.ReadKey();
        }
    }
}
