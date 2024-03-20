using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace HomeTaskMod13
{
    internal class Program
    {
        static IEnumerable<string> MethodForArray(string[] args) 
        {
            
            Console.WriteLine("Слова, состоящие более, чем из пяти символов:");
            foreach (var arg in args) 
            {
                if (arg.Length > 5) 
                { 
                    yield return arg;
                }
            }
        }

        static string[] RandomGenerator(int quantity)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                {1, "книга" }, {2, "чай" }, {3, "телефон" }, {4, "кот" }, {5, "код" }, {6, "кошелек" }, {7, "массив" }, {8, "часы" }, {9, "паспорт" }, {10, "итератор" },
                {11, "объект" }, {12, "конкатенация" }, {13, "компьютер" }, {14, "робот" }, {15, "компилятор" }, {16, "наушники" }, {17, "карандаш" },
                {18, "пульт" }, {19, "нос" }, {20, "джойстик" }
            };
            Random random = new Random();
            string[] randomWords = new string[quantity];
            for (int i = 0; i < quantity; i++)
            {
                int count = random.Next(1, 20);
                randomWords[i] = dictionary[count];
            }
            return randomWords;
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string[] randomWords = RandomGenerator(5);
            Console.WriteLine("Все слова из массива:");
            foreach (var word in randomWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();

            foreach (var word in MethodForArray(randomWords)) 
            {
                Console.WriteLine(word);
            }
        }

        
    }
}
