using System;

namespace BalancedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isBalanced = true;
            int charToIntOffset = 48;
            int sum = 0;
            do
            {
                string input = Console.ReadLine();

                // Chars can be represented as numbers, so we don't need to parse them explicitly
                if (input[0] + input[2] - charToIntOffset == input[1])
                {
                    sum += int.Parse(input);
                }
                else
                {
                    isBalanced = false; ;
                }
            }
            while (isBalanced);

            Console.WriteLine(sum);
        }
    }
}
