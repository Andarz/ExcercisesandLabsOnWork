namespace Reversed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversedString = new string(input.Reverse().ToArray());
            Console.WriteLine(reversedString);

        }
    }
}