using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main()
        {
            // Create an instance of the Random class to generate a random number
            Random randomNumber = new Random();

            // Generate a random number between 1 and 10
            int randomNum = randomNumber.Next(1, 11); // Upper bound is exclusive, so use 11

            // Display the random number (for debugging; remove this in actual gameplay)
            // Console.WriteLine(randomNum);

            // Set the number of trials allowed
            int trial = 4;

            // Infinite loop for user attempts
            while (true)
            {
                Console.WriteLine("Pick a number between 1 and 10:");
                int number;

                // Validate user input to ensure it's a number
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue; // Restart loop
                }

                trial--; // Reduce trial count after each attempt

                // Check if the guessed number is correct
                if (number == randomNum)
                {
                    Console.WriteLine("You Won!");
                    break; // Exit the loop if guessed correctly
                }

                // Check if trials are exhausted
                if (trial == 0)
                {
                    Console.WriteLine($"You Lost. The correct number was {randomNum}. ");
                    break; // Exit the loop
                }

                Console.WriteLine($"Wrong guess! You have {trial} attempts left.");
            }
        }
    }
}
