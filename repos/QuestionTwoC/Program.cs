using System;

namespace FactorialCalculatorApp
{
    class Program
    {
        static void Main()
        {
            // Initialize factorial result to 1 (since factorial of 0 is 1)
            int factorial = 1;

            // Prompt the user to enter a number
            Console.WriteLine("Enter a Number:");
            int value = Convert.ToInt32(Console.ReadLine());

            // Store the original value for displaying results
            int num = value;

            // Loop to calculate the factorial of the given number
            for (int i = 1; i <= num; i++)
            {
                factorial *= value; // Multiply the factorial by the current value
                value--; // Decrease the value for the next iteration
            }

            // Display the factorial result
            Console.WriteLine($"{num}! = {factorial}");
        }
    }
}
