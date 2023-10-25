namespace DemoStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] digits = inputLine.Split(' ');
            int[] intDigits = Array.ConvertAll(digits, int.Parse);
            Stack<int> myStack = new Stack<int>();
            int sum = 0;
            
            foreach (int digitChar in intDigits)
            {
                myStack.Push(digitChar);
            }
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commArr = command.Split(' ');
                string token = "";
                foreach (string elem in commArr)
                {
                    
                    if (int.TryParse(elem, out _))
                    {
                        int number = int.Parse(elem.ToString());

                        switch (token)
                        {
                            case "add":
                                myStack.Push(number);
                                break;
                            case "remove":
                                if (number > myStack.Count)
                                    continue;
                                for (int i = 0; i < number; i++)
                                {
                                    myStack.Pop();
                                }
                                break;
                        }
                    }
                    else
                    {
                        token = elem.ToLower();
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            foreach (int i in myStack)
            {
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
