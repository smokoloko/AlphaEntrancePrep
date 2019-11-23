using System;

namespace Spellcaster
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            // The length of the squashed word will be the legth of the input - the amount of spaces(which are equal to the elements in the array - 1)
            int newWordLength = input.Length - words.Length + 1;

            char[] newArray = new char[newWordLength];

            int counter = 0;
            int currentWordPosition = 0;

            // Part One : Combine the word
            while(counter < newWordLength)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    if(words[i].Length - currentWordPosition - 1 >= 0)
                    {
                        newArray[counter] = words[i][words[i].Length - currentWordPosition - 1];
                        counter++;
                    }
                }
                currentWordPosition++;
            }

            // Part Two : The Black Magic
            for (int i = 0; i < newArray.Length; i++)
            {
                // In other words - the position of the letter in the alphabet
                int positionsToBeMoved = (newArray[i].ToString().ToLower()[0] - 96) % newArray.Length;
                int shiftPosition = i;
                
                for (int j = 0; j < positionsToBeMoved; j++)
                {
                    char temp = newArray[shiftPosition];

                    // This is the slow part - when we shift from the last index, we need to shift the whole thing
                    if(shiftPosition == newArray.Length - 1)
                    {
                        // Temp array for shifting all characters one position to the right
                        // This is due to the shifting of the last element to first position
                        char[] tempArray = new char[newArray.Length];
                        for (int z = 1; z < newArray.Length; z++)
                        {
                            tempArray[z] = newArray[z-1];
                        }
                        tempArray[0] = temp;

                        // Override the old array with the temp array that contains the shifted elements
                        newArray = tempArray;

                        //Our element is now at position 0
                        shiftPosition = 0;
                    }

                    // This is the easy part - just switch our current letter with the next
                    else
                    {
                        newArray[shiftPosition] = newArray[shiftPosition + 1];
                        newArray[shiftPosition + 1] = temp;
                        shiftPosition++;
                    }
                }
            }

            Console.WriteLine(new string(newArray));
        }
    }
}
