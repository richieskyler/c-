using System;
using System.Collections.Generic;

namespace UniqueNumberListApp
{
    class Program
    {
        static void Main()
        {
            // Initialize a list to store the numbers
            List<int> numbers = new List<int>();

            // Loop until the list contains 5 unique numbers
            while (numbers.Count < 5)
            {
                // Prompt the user to enter a number
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                // Check if the number has already been entered
                if (numbers.Contains(number))
                {
                    // Inform the user that the number is a duplicate
                    Console.WriteLine("You've already entered this number. Please try again.");
                }
                else
                {
                    // Add the number to the list if it's unique
                    numbers.Add(number);
                }
            }

            // Sort the list of numbers in ascending order
            numbers.Sort();

            // Display the sorted numbers
            Console.WriteLine("Sorted numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
