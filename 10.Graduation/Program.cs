namespace _10.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();            
            int gradeCounter = 1;
            double markSum = 0;
            int unsuccCount = 0;

            while (gradeCounter <= 12)
            {
                double mark = double.Parse(Console.ReadLine());

                if (mark < 4.0)
                {
                    unsuccCount++;

                    if (unsuccCount > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {gradeCounter - 1} grade");
                        // Environment.Exit(0);
                        return;
                    }
                }
                gradeCounter++;
                markSum += mark;


                // mark = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{name} graduated. Average grade: {(markSum / 12):f2}");
        }
    }
}