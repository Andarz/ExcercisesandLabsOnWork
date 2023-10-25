namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aimMoney = double.Parse(Console.ReadLine());
            double realMoney = double.Parse(Console.ReadLine());

            int consecDays = 0;
            int days = 0;

            while (true)
            {
                string CommandType = Console.ReadLine();
                double actionMoney = double.Parse(Console.ReadLine());

                if (CommandType == "spend")
                {
                    realMoney -= actionMoney;
                    if (realMoney < 0)
                    {
                        realMoney = 0;
                    }
                    consecDays++;
                    days++;
                }
                else
                {
                    realMoney += actionMoney;
                    days++;
                    consecDays = 0;
                }
                if (consecDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    return;
                }
                if (realMoney >= aimMoney)
                {
                    break;
                }

            }
            if (realMoney >= aimMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}