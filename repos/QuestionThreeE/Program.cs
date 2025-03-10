using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestNumbersApp
{
    class Program
    {
        static void Main()
        {
            // Infinite loop to ensure valid input is received before processing
            while (true)
            {
                // Prompt the user to enter a list of numbers separated by commas
                Console.Write("Enter a list of numbers separated by comma: ");
                string input = Console.ReadLine();

                // Split the input string into an array of number strings based on commas
                string[] numberStrings = input.Split(',');

                // Check if the number of inputs is less than 5 or if the input is empty
                if (numberStrings.Length < 5 || numberStrings.Length == 0)
                {
                    // Inform the user that at least 5 numbers are required and prompt for input again
                    Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                    continue; // Restart the loop if input is invalid
                }

                // Convert the array of number strings to a list of integers
                List<int> numbers = new List<int>();
                foreach (string numberString in numberStrings)
                {
                    numbers.Add(int.Parse(numberString.Trim())); // Trim any spaces and convert to integer
                }

                // Order the numbers in ascending order and take the 3 smallest numbers
                List<int> smalle
