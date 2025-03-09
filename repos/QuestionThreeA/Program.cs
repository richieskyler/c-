using System;
using System.Collections.Generic;

namespace PostLikesApp
{
    class Program
    {
        static void Main()
        {
            // Initialize a counter for the number of names entered
            int count = 0;

            // Create a list to store the names of people who liked the post
            List<string> names = new List<string>();

            // Loop until the user enters an empty string (presses Enter without typing anything)
            while (true)
            {
                // Prompt the user to enter a name
                Console.WriteLine("Enter a name: ");
                string name = Console.ReadLine();

                // Add the entered name to the list
                names.Add(name);

                // If the input is an empty string, process the names and break the loop
                if (name == "")
                {
                    // Calculate the number of names entered (excluding the empty input)
                    int namesLength = names.Count - 1;

                    // If no names were entered, exit the loop
                    if (namesLength == 0)
                    {
                        break;
                    }
                    // If only one name is entered, display a specific message
                    else if (namesLength == 1)
                    {
                        Console.WriteLine($"{names[0]} liked your post");
                        break;
                    }
                    // If two names are entered, display a different message
                    else if (namesLength == 2)
                    {


