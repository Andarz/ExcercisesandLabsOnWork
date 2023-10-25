namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "End")
                {
                    break;
                }
                double money = double.Parse(input);

                if (money >= 0)
                {
                    Console.WriteLine($"Increase: {money:f2}");
                    balance += money;
                }
                else
                {
                    double print = Math.Abs(money);
                    Console.WriteLine($"Decrease: {print:f2}");
                    balance += money;
                }

            }

            Console.WriteLine($"Balance: {balance:f2}");
        }
    }
}