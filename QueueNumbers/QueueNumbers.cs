using System.Linq.Expressions;

namespace QueueNumbers
{
    public class QueueNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');

            Queue<int> numbersQueue = new Queue<int>();

            foreach (string token in tokens)
            {
                if (int.TryParse(token, out int number))
                {
                    numbersQueue.Enqueue(number);
                }
            }

            PrintEvenNumbers(numbersQueue);
        }

        public static void PrintEvenNumbers(Queue<int> numbersQueue)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int n in numbersQueue)
            {
                if (n % 2 == 0)
                {
                    evenNumbers.Add(n);
                }
            }

            string result = string.Join(", ", evenNumbers);
            Console.WriteLine(result);
        }
    }
}