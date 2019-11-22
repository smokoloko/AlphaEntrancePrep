using System;

namespace MockExam1
{
    class CrookedDigits
    {
        static void Main(string[] args)
        {
            // We don't need to parse the input to number because we can operate directly on the string
            string input = Console.ReadLine();

            // The value of the the char '0'
            // Will be used to convert the chars to their number representation
            // In a variable for improved readability
            int charValueOffset = 48;

            // We will update the value of the string in each iteration based on the value that we get from the algorith
            while(input.Length > 1)
            {
                int currentNumber = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        currentNumber += (input[i] - charValueOffset);
                    }
                }

                // Update the string we are iterating over
                input = currentNumber.ToString();
            }

            Console.WriteLine(input);
        }
    }
}
