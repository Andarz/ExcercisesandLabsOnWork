namespace StackCalc
{
    internal class StackCalc
    {
        public static void Main(string[] args)
        {
            string expr = Console.ReadLine();
            string[] tokens = expr.Split(' ');
            Stack<string> tokenStack = new Stack<string>();
            foreach (string x in tokens)
            {
                tokenStack.Push(x);
            }
            Stack<string> reversedTokensStack = ReverseStack(tokenStack);
            int result = int.Parse(reversedTokensStack.Pop());

            while (reversedTokensStack.Count > 0)
            {
                string sign = reversedTokensStack.Pop();
                int number = int.Parse(reversedTokensStack.Pop());

                switch (sign)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;
                }
            }Console.WriteLine(result);
        }
        public static Stack<T> ReverseStack<T>(Stack<T> inputStack)
        {
            // Создаем временный список для хранения элементов
            List<T> tempList = new List<T>();

            // Переносим элементы из стека в список
            while (inputStack.Count > 0)
            {
                tempList.Add(inputStack.Pop());
            }

            return new Stack<T>(tempList);
        }

    }
}


