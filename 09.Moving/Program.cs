namespace _09.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * length * height;
            int volumeTaken = 0;
            string input = Console.ReadLine();

            while (input != "Done")
            {
                volumeTaken = int.Parse(input);
                volume -= volumeTaken;
                if (volume <= 0)
                {
                    break;
                }
                if (volume > 0)
                {
                    Console.WriteLine($"{volume} Cubic meters left.");                    
                }
                input = Console.ReadLine();
            }
            if (volume > 0)
            {
                Console.WriteLine($"{volume} Cubic meters left.");
            }
            else
            {
                volume = -volume;
                Console.WriteLine($"No more free space! You need {volume} Cubic meters more.");
            }
        }
    }
}