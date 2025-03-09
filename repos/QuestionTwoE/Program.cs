using System;
using System.Linq;

namespace MaximumNumberFinder
{
    class Program
    {
        static void Main()
        {
            // Prompt the user to enter a list of numbers separated by commas
            Console.WriteLine("Enter a list of numbers separated by commas:");
            string listOfNums = Console.ReadLine();

            // Split the input string into an array of number strings
            string[] lists = listOfNums.Split(',');

            // Convert the string array into an integer array
            int[] numLists = lists.Select(int.Parse).ToArray();

            // Sort the array in ascending order
            Array.Sort(numLists);

            // Get the last element in the sorted array, which is the maximum number
            int maxNum = numLists[numLists.Length - 1];

            // Display the maximum number
            Console.WriteLine("The Maximum Number is: " + maxNum);
        }
    }
}
