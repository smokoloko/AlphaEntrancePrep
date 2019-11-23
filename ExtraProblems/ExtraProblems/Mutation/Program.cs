using System;
using System.Linq;

namespace Mutation
{
    class Program
    {
        static void Main(string[] args)
        {
            // We actually don't need this
            string amount = Console.ReadLine();

            string[] numbers = Console.ReadLine().Split(' ').ToArray();

            int charToIntOffset = 48;

            int mutated = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                string currentNumber = numbers[i];
                char[] newNumber = new char[currentNumber.Length];

                // Perform the mutation
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int num = currentNumber[j] - charToIntOffset;

                    if (num == 0)
                    {
                        num = 9;
                    }
                    else if (num == 9)
                    {
                        num = 0;
                    }
                    else if (num % 2 == 0)
                    {
                        num -= 1;
                    }
                    else
                    {
                        num += 1;
                    }
                    newNumber[j] = (char)(num + charToIntOffset);
                }

                // Save the number before and after in int variables
                int beforeMutation = int.Parse(currentNumber);
                int afterMutation = int.Parse(new string(newNumber));

                // Just for convienience
                int smaller = Math.Min(afterMutation, beforeMutation);
                int bigger = Math.Max(afterMutation, beforeMutation);

                // Greatest Common Divisor
                int gdc = 1;

                // Algorithm for calculating GDC
                if (bigger % smaller == 0)
                {
                    gdc = smaller;
                }
                else
                {
                    for (int k = 2; k < smaller / 2;)
                    {
                        if (bigger % k == 0 && smaller % k == 0)
                        {
                            bigger /= k;
                            smaller /= k;
                            gdc *= k;
                        }
                        else
                        {
                            k++;
                        }
                    }
                }

                if (gdc < 10)
                {
                    mutated++;
                }
            }

            Console.WriteLine(mutated);
        }
    }
}
