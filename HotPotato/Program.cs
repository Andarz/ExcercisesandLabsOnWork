namespace HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int toss = int.Parse(Console.ReadLine());
            
            string[] kids = input.Split(' ');
            Queue<string> kidsQueue = new Queue<string>();
            
            foreach (string x in kids)
            {
                kidsQueue.Enqueue(x);
            }

            int n = kidsQueue.Count;

            while (n != 1)
            {
                string currKid = "";
                for (int i = 1; i <= toss; i++ )
                {
                    currKid = kidsQueue.Dequeue();
                    kidsQueue.Enqueue(currKid);
                    if (i == toss - 1)
                    {
                        Console.WriteLine($"Removed{kidsQueue.Dequeue()}");
                    }
                }
            }
        }
    }
}