using System;

namespace TimeValidationApp
{
    class Program
    {
        static void Main()
        {
            // Ask the user to enter a time value in 24-hour format (e.g., 19:00)
            Console.Write("Enter a time value in 24-hour format (e.g., 19:00): ");
            string input = Console.ReadLine();

            // Check if the input is empty or invalid
            if (string.IsNullOrWhiteSpace(input) || !IsValidTime(input))
            {
                // If input is invalid, notify the user
                Console.WriteLine("Invalid Time");
            }
            else
            {
                // If input is valid, confirm the input is okay
                Console.WriteLine("Ok");
            }
        }

        // Method to validate if the input string is a valid time in 24-hour format
        static bool IsValidTime(string time)
        {
            // Try to parse the time into a DateTime object using the 24-hour format
            return DateTime.TryParseExact(time, "HH:mm", null, System.Globalization.DateTimeStyles.None, out _);
        }
    }
}
