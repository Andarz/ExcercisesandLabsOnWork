namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input numbers separated by a space
            Console.Write("Enter numbers separated by a space: ");
            string inputStr = Console.ReadLine();

            // Split the input string into an array of numbers
            string[] numbers = inputStr.Split();

            // Initialize a dictionary to store the count of each number
            Dictionary<string, int> numberCount = new Dictionary<string, int>();

            // Iterate through the numbers and count their occurrences
            foreach (var num in numbers)
            {
                double parsedNum;
                if (double.TryParse(num, out parsedNum))
                {
                    // Use string interpolation to round the number to one decimal place
                    string numStr = $"{parsedNum:F1}";

                    if (numberCount.ContainsKey(numStr))
                    {
                        numberCount[numStr]++;
                    }
                    else
                    {
                        numberCount[numStr] = 1;
                    }
                }
            }

            // Print the count of each number
            foreach (var entry in numberCount)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value} times");
            }
        }
    }
}