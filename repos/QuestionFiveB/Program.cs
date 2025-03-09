using System;

namespace LongestWordApp
{
    class Program
    {
        static void Main()
        {
            // Ask the user to enter a text
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();

            // Find the longest word in the text
            string longestWord = FindLongestWord(text);

            // Display the result
            if (!string.IsNullOrEmpty(longestWord))
            {
                // If a longest word is found, display it
                Console.WriteLine("Longest word: " + longestWord);
            }
            else
            {
                // If no words are found, display this message
                Console.WriteLine("No words found.");
            }
        }

        // Method to find the longest word in a given text
        static string FindLongestWord(string text)
        {
            // Check if the text is null or empty
            if (string.IsNullOrWhiteSpace(text))
            {
                return null; // Return null if no text is provided
            }

            // Split the text into words based on spaces and punctuation marks
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Initialize the variable to store the longest word
            string longestWord = string.Empty;

            // Loop through each word in the array to find the longest one
            foreach (var word in words)
            {
                // If the current word is longer than the longest word found so far
                if (word.Length > longestWord.Length)
                {
                    longestWord = word; // Update the longest word
                }
            }

            // Return the longest word found
            return longestWord;
        }
    }
}
