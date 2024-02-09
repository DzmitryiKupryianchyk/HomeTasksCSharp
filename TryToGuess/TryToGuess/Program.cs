namespace TryToGuess
{
    internal class Program
    {
        private static int attempt;
        private static int value;

        public static void Main(string[] args)
        {
            
            bool end = false;
            while (!end)
            {
                try
                {
                    Guess();
                    end = true;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Please, input number from 0 to 10");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("You forgot to fill in the gap");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong :(");
                }

                //finally { Console.WriteLine("Finish"); }
            }


        }
        public static void Guess() 
        {
            Console.WriteLine("I made a number from 0 to 10. Try to guess :) ");
            Random guessed = new Random();
            int value = guessed.Next(0, 10);

            while (attempt != value)
            {
                attempt = int.Parse(Console.ReadLine());
                
                if (attempt < 0 || attempt > 10)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                if (attempt == null)
                {
                    throw new System.ArgumentNullException();
                }
                if (attempt == value) break;
                Console.WriteLine("Incorrect. You can try again");
            }
            Console.WriteLine("Congratulations, you won!");
        }
        
    }
}
