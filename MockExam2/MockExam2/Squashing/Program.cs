using System;

namespace Squashing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Not optimal, but easiest - we can use only a variable to keep the last number and do all in just one loop
            // However this is way more readable

            int amount = int.Parse(Console.ReadLine());
            string[] numbers = new string[amount];
            int[] squashed = new int[amount - 1];
            int[] merged = new int[amount - 1];

            int charToIntOffset = 48;

            for (int i = 0; i < amount; i++)
            {
                numbers[i] = Console.ReadLine();
            }

            for (int i = 0; i < amount - 1; i++)
            {
                string current = numbers[i];
                string next = numbers[i + 1];
                merged[i] = (current[1] - charToIntOffset) * 10 + (next[0] - charToIntOffset);
                squashed[i] = (current[0] - charToIntOffset) * 100
                    + ((current[1] + next[0] - 2 * charToIntOffset) % 10) * 10
                    + (next[1] - charToIntOffset);
            }

            Console.WriteLine(string.Join(" ", merged));
            Console.WriteLine(string.Join(" ", squashed));
        }
    }
}
