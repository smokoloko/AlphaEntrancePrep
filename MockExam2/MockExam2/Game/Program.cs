using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int charToIntOffset = 48;

            int a = input[0] - charToIntOffset;
            int b = input[1] - charToIntOffset;
            int c = input[2] - charToIntOffset;

            int combination1 = a + b + c;
            int combination2 = a * b + c;
            int combination3 = a + b * c;
            int combination4 = a * b * c;

            Console.WriteLine(Math.Max(Math.Max(Math.Max(combination1, combination2), combination3), combination4));
        }
    }
}
