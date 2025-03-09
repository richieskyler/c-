using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsecutiveNumbersApp
{
    class Program
    {
        static void Main()
        {
            // Prompt the user to enter a few numbers separated by a hyphen
            Console.Write("Enter a few numbers separated by a hyphen: ");
            string input = Console.ReadLine();

            // Split the input string into an array of number strings using the hyphen as a separator
            string[] numberStrings = input.Split('-');

            // Convert the array of number strings into a list of integers, trimming any spaces
            List<int> numbers = numberStrings.Select(n => int.Parse(n.Trim())).ToList();

            // Check if the numbers are consecutive
            bool isConsecutive = AreNumbersConsecutive(numbers);

            // Output whether the numbers are consecutive or not
            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }

        // Method to determine if the numbers in the list are consecutive
        static bool AreNumbersConsecutive(List<int> numbers)
        {
            // Sort the numbers in ascending order
            numbers.Sort();

            // Check if each number in the sorted list is consecutive
            for (int i = 1; i < numbers.Count; i++)
            {
                // If the current number is not exactly one greater than the previous one, return false
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    return false;
                }
            }

            // If all numbers are consecutive, return true
            return true;
        }
    }
}
