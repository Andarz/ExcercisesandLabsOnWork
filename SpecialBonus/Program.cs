namespace SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());
            double lastNumber = 0;
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                
                if (number == stopNumber)
                {
                    break;
                }
                lastNumber = number * 1.2;             


            }

            Console.WriteLine(lastNumber);
        }
    }
}