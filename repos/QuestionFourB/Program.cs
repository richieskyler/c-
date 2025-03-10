using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateCheckApp
{
    class Program
    {
        static void Main()
        {
            // Prompt the user to enter a few numbers separated by a hyphen (e.g., 5-6-7-8-9)
            Console.Write("Enter a few numbers separated by a hyphen (e.g., 5-6-7-8-9): ");
            string input = Console.ReadLine();

            // Exit if the input is empty or contains only white spaces
            if (string.IsNullOrWhiteSpace(input))
            {
                return; // Exit the program if no input is provided
            }

            // Split the input string by hyphen into an array of number strings
            string[] numberStrings = input.Split('-');

            // Convert the string array into a list of integers, trimming any spaces
            List<int> numbers = numberStrings.Select(n => int.Parse(n.Trim())).ToList();

            // Check if there are any duplicate numbers in the list
            bool hasDuplicates = numbers.Count != numbers.Distinct().Count();

            // Output the result based on whether there are duplicates
            if (hasDuplicates)
            {
                Console.WriteLine("Duplicate");
            }
        }
    }
}
