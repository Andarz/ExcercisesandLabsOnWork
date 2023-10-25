namespace _06.Steps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int goal = 10000;
            int steps = 0;
            int totalSteps = 0;

            while (input != "Going home")
            {
                steps = int.Parse(input);
                totalSteps += steps;
                if (totalSteps >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - goal} steps over the goal!");
                    return;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            steps = int.Parse(input);
            totalSteps += steps;

            if (totalSteps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - goal} steps over the goal!");
            }
            else
                Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
        }
    }
}
