using System;

namespace VowelCountApp
{
    class Program
    {
        static void Main()
        {
            // Ask the user to enter an English word
            Console.Write("Enter an English word: ");
            string word = Console.ReadLine();

            // Count the number of vowels in the word
            int vowelCount = CountVowels(word);

            // Display the result
            Console.WriteLine("Number of vowels: " + vowelCount);
        }

        // Method to count the vowels in a given word
        static int CountVowels(string word)
        {
            // Initialize the vowel count to 0
            int count = 0;

            // Define the vowels in English
            string vowels = "aeiouAEIOU";

            // Iterate over each character in the word
            foreach (char letter in word)
            {
                // Check if the character is a vowel
                if (vowels.Contains(letter))
                {
                    count++; // Increment the vowel count
                }
            }

            // Return the total number of vowels found
            return count;
        }
    }
}
