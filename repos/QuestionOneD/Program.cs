using System;

namespace SpeedCheckApp
{
    class Program
    {
        static void Main()
        {
            // Prompt the user to enter the speed limit
            Console.WriteLine("Enter the Speed Limit:");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the car's speed
            Console.WriteLine("Enter the Speed of Car:");
            int speedOfCar = Convert.ToInt32(Console.ReadLine());

            // Check if the car's speed is within the limit
            if (speedOfCar < speedLimit)
            {
                Console.WriteLine("Ok"); // The car is within the speed limit
            }
            else
            {
                // Calculate demerit points for exceeding the speed limit
                double demeritsPoint = ((speedOfCar - speedLimit) / 5) * 1;

                // If demerit points exceed 12, suspend the license
                if (demeritsPoint > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    // Display the number of demerit points
                    Console.WriteLine("Demerit Points: " + demeritsPoint);


