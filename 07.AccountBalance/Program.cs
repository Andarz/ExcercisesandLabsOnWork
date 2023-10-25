namespace _07.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double balance = 0;

            while (input != "NoMoreMoney")
            {
                double income = double.Parse(input);
                
                if (income < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase:{income}");
                balance += income;

                

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {balance}");


        }
    }
}