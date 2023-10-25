using System;

namespace SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int initialNumber = number;
            bool isSpecial = true;

            while (number > 0)
            {
                int lastNum = number % 10;

                if (initialNumber % lastNum != 0)
                {
                    isSpecial = false;
                    break;
                }

                number = number / 10;
            }

            if (isSpecial)
            {
                Console.WriteLine(initialNumber + " is special");
            }
            else
                Console.WriteLine(initialNumber + " is not special");
        }
    }
}