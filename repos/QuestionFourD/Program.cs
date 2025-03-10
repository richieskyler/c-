using System;
using System.Linq;

namespace StringManipulationApp
{
    class Program
    {
        static void Main()
        {
            // Ask the user to enter a few words separated by a space
            Console.Write("Enter a few words separated by a space: ");
            string input = Console.ReadLine();

            // Convert the input to PascalCase
            string pascalCase = ConvertToPascalCase(input);

            // Display the result in PascalCase
            Console.WriteLine("PascalCase Variable Name: " + pascalCase);
        }

        // Method to convert input string to PascalCase
        static string ConvertToPascalCase(string input)
        {
            // Split the input into words, capitalize the first letter of each, and join them together

