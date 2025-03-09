using System;

namespace DivisibilityCounterApp
{
    class Program
    {
        static void Main()
        {
            // Initialize a counter to track numbers divisible by 3
            int count = 0;

            // Loop through numbers from 1 to 100
            for (int num = 1; num <= 100; num++)
            {
                // Check if the number is divisible by 3
                if (num % 3 == 0)
                {
                    count++; // Increment the counter
                }
            }

            // Output the total count of numbers divisible by 3
            Console.WriteLine("Total numbers divisible by 3 from 1 to 100: " + count);
        }
    }
}
