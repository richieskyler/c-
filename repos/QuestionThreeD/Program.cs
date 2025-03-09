using System;
using System.Collections.Generic;

namespace UniqueNumberCollectionApp
{
    class Program
    {
        static void Main()
        {
            // Initialize a list to store the numbers
            List<int> numbers = new List<int>();

            // Infinite loop to keep prompting the user for input until they type 'Quit'
            while (true)
            {
                // Prompt the user to enter a number or type 'Quit' to exit
                Console.Write("Enter a number or type 'Quit' to exit: ");
                string input = Console.ReadLine();

                // Check if the user wants to exit the loop
                if (input.ToLower() == "quit")
                {
                    break; // Exit the loop if 'Quit' is entered
                }

                // Parse the input as an integer and add it to the numbers list
                int number = int.Parse(input);
                numbers.Add(number);
            }

            // Create a HashSet from the list to automatically remove duplicates
            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            // Display the unique numbers entered by the user
            Console.WriteLine("Unique numbers you entered:");
            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine(number); // Print each unique number
            }
        }
    }
}
