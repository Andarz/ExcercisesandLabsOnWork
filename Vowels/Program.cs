namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int sum = 0;

            foreach (var item in name)
            {
                switch (item)
                {
                    case 'a': sum += 1; return;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                }
            }
            Console.WriteLine("Vowels sum = " + sum);
        }
    }
}