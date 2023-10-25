namespace Division234
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int divisidleBy2 = 0;
            int divisidleBy3 = 0;
            int divisidleBy4 = 0;


            for (int i = 0; i < n; i++)
            {
                int number = int.Parse((Console.ReadLine()));

                if (number % 2 == 0)
                {
                    divisidleBy2++;
                }
                if (number % 3 == 0)
                {
                    divisidleBy3++;
                }
                if (number % 4 == 0)
                {
                    divisidleBy4++;
                }
            }

            double percBy2 = divisidleBy2 * 1.0 / n * 100;
            double percBy3 = divisidleBy3 * 1.0 / n * 100;
            double percBy4 = divisidleBy4 * 1.0 / n * 100;

            Console.WriteLine($"{percBy2:f2}%");
            Console.WriteLine($"{percBy3:f2}%");
            Console.WriteLine($"{percBy4:f2}%");

        }
    }
}