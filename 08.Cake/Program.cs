namespace _08.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int area = width * length;
            int piecesTaken = 0;
            string input = Console.ReadLine();

            while (input != "STOP")
            {
                piecesTaken = int.Parse(input);
                area -= piecesTaken;
                if (area < 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (area > 0)
            {
                Console.WriteLine($"{area} pieces are left.");
            }
            else
            {
                area = -area;
                Console.WriteLine($"No more cake left! You need {area} pieces more.");
            }
        }
    }
}