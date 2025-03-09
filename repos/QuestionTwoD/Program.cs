using System;

namespace SumCalculatorApp
{
    class Program
    {
        static void Main()
        {
            // Initialize a variable to store the sum of entered numbers
            int sum = 0;

            // Infinite loop to continuously ask for user input
            while (true)
            {
                Console.WriteLine("Enter a number (or type 'ok' to finish):");
                string value = Console.ReadLine();

                // Check if the user entered "ok" to stop the loop
                if (value.ToLower() == "ok")
                {
                    break; // Exit the loop
                }

                try
                {
                    // Convert user input to an integer and add it to the sum
                    int num = Convert.ToInt32(value);
                    sum += num;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or type 'ok' to stop.");
                }
            }

            // Display the total sum of all entered numbers
            Console.WriteLine("The sum of the numbers is: " + sum);
        }
    }
}
