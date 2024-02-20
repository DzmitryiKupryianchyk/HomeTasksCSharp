namespace MyLibrary
{
    public class ArrayWorker
    {
        int[] numbers;
        int[] result;
        int len;
        public ArrayWorker(int[] numbers, int len)
        {
            this.numbers = numbers;
            this.len = len;
            result = new int[len];
        }

        public void ArrayInv()
        {
            for (int i = 0; i < len; i++)
            {
                result[i] = numbers[len - i - 1];
            }
            numbers = result;
        }
        public void OutputToConsole()
        {
            Console.WriteLine("Инвертированный массив");
            foreach (int i in numbers)
            {
                Console.Write(i);
                Console.Write("-");
                Thread.Sleep(50);
            }
            Console.WriteLine();
        }
    }
}
