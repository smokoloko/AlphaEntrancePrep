using System;
using System.Linq;

namespace PrimeTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            // Create an array to keep true/false for each index
            // Each index corresponds to a number. 
            // Since the first index is 0, we assume that the bool telling is if a number is prime is at number - 1
            // This is to avoid checking if a number is prime multiple times
            bool[] primeChecker = new bool[number];

            for (int i = 0; i < primeChecker.Length; i++)
            {
                int currentNumber = i + 1;
                bool isPrime = true;

                for (int j = 2; j <= currentNumber / 2; j++)
                {
                    if (currentNumber % j == 0)
                    {
                        isPrime = false;
                    }
                }

                primeChecker[i] = isPrime;

                if (primeChecker[i])
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        if (primeChecker[j])
                        {
                            Console.Write(1);
                        }
                        else
                        {
                            Console.Write(0);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
