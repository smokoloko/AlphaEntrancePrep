using System;

namespace Word_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int inputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputs; i++)
            {
                // Since we may have repetition of symbols, we need to keep information about which indexes we already used

                bool[] usedLetters = new bool[word.Length];

                string current = Console.ReadLine();

                // Anagrams are always with the same length as the original
                if (current.Length != word.Length)
                {
                    Console.WriteLine("No");
                    continue;
                }

                for (int j = 0; j < current.Length; j++)
                {
                    char currentLetter = current[j];
                    bool found = false;
                    
                    // Try to find the char - use the usedLetters array to keep track of used indexes
                    for (int k = 0; k < word.Length; k++)
                    {
                        if(currentLetter == word[k] && !usedLetters[k])
                        {
                            // Letter is found - save it in array and break
                            found = true;
                            usedLetters[k] = true;
                            break;
                        }
                    }

                    // Letter is not found => it's not an anagram
                    if (!found)
                    {
                        Console.WriteLine("No");
                        break;
                    }
                    
                    if(j == current.Length - 1)
                    {
                        Console.WriteLine("Yes");
                    }
                }
            }
        }
    }
}
