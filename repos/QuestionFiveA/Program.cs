using System;

namespace WordCountApp
{
    class Program
    {
        static void Main()
        {
            // Ask the user to enter a text
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();

            // Count the number of words in the text
            int wordCount = CountWords(text);

            // Display the result
            Console.WriteLine("Number of words: " + wordCount);
        }

        // Method to count the number of words in a given text
        static int CountWords(string text)
        {
            // Check if the text is null or empty
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0; // Return 0 if no text is provided
            }

            // Split the text into words based on spaces or punctuation
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Return the number of words in the text
            return words.Length;
        }
    }
}
