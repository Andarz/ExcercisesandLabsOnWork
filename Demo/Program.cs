using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            // Вводим количество пар
            Console.Write("Введите количество пар: ");
            int pairCount = int.Parse(Console.ReadLine());

            // Заполняем словарь парами ввода с консоли
            for (int i = 0; i < pairCount; i++)
            {
                Console.Write($"Введите ключ для пары {i + 1}: ");
                string key = Console.ReadLine();

                Console.Write($"Введите значение для ключа {key}: ");
                int value = int.Parse(Console.ReadLine());

                // Добавляем пару в словарь
                myDictionary.Add(key, value);
            }

            // Выводим содержимое словаря
            Console.WriteLine("\nСодержимое словаря:");
            foreach (var pair in myDictionary)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}